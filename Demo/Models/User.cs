using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public Permisson Permission { get; set; }
    }
}
