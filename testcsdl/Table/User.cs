using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace testcsdl.Table
{
    public partial class User
    {

        public User()
        {
            HocVus = new HashSet<HocVu>();
        }
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        public int? DonViID { get; set; }
        public int? LopID { get; set; }

        public virtual DonVi DonVi { get; set; }
        public virtual ICollection<HocVu> HocVus { get; set; }
        public virtual Lop Lop { get; set; }
    }
}
