using System.ComponentModel.DataAnnotations;

namespace ManhDepTrai.Models
{
    public class StudentAddress
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressDetails { get; set; }
        public int StudentID { get; set; }

        public Student student { get; set; }
    }
}
