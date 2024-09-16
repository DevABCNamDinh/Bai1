using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManhDepTrai.Models
{
    [Table("SinhVien")]
    public class Student
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        // bắt buộc, notnull
        [Required(ErrorMessage ="Ten bat buoc nhap")]
        //độ dài chuỗi
        [StringLength(50,ErrorMessage ="Nhỏ hơn 50 kí tự")]
        public string Name { get; set;}
        [Range(18,50)]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        
        public string Phone {  get; set; }
        [Range(typeof(DateTime), "1/1/0001", "1/1/3000")]

        public int MyProperty { get; set; }
        public StudentAddress studentAddress { get; set; }
        public int ClassID { get; set; }

        public ClassX Class { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
