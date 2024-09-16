
using ManhDepTrai.Models;
using Microsoft.EntityFrameworkCore;

namespace Xuong_C_.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {
            
        }

        public DbSet<Student> students { get; set; }
        public DbSet<StudentAddress> studentAddresses { get; set; }

        public DbSet<ClassX> classes { get; set; }
        public DbSet<Course> courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //thiết lập mối quan hệ 1-1
            modelBuilder.Entity<Student>()
                .HasOne(s => s.studentAddress)
                .WithOne(sa => sa.student)
                .HasForeignKey<StudentAddress>(ad => ad.StudentID);

            //thiết lập class 1-n
            modelBuilder.Entity<ClassX>()
                .HasMany(s => s.Students)
                .WithOne(ca => ca.Class)
                .HasForeignKey(ca => ca.ClassID);
            //thiết lập nhiều nhiều
            modelBuilder.Entity<Student>()
                .HasMany(c => c.Courses)
                .WithMany(s => s.Students)
                .UsingEntity(a => a.ToTable("BangTrungGian"));
             
        }
    }
}
