using System.ComponentModel.DataAnnotations;

namespace testcsdl.Table
{
    public partial class Role
    {
        [Key]
        public int RolesID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }
        public bool Quyen { get; set; }
    }
}
