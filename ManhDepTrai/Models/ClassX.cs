using System.ComponentModel.DataAnnotations;

namespace ManhDepTrai.Models
{
    public class ClassX
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
