using System;
using System.ComponentModel.DataAnnotations;

namespace CyrillicSoftware.Models
{
    public class CoctailModel
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserSearch { get; set; }
        public DateTime Time { get; set; }
    }
}