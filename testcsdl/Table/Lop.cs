using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace testcsdl.Table
{
    public partial class Lop
    {

        public Lop()
        {
            Users = new HashSet<User>();
        }
        public int LopID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }
        public int? DonViID { get; set; }

        public virtual DonVi DonVi { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
