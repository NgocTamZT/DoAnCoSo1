using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace testcsdl.Table
{
    public partial class DonVi
    {

        public DonVi()
        {
            DanhMucs = new HashSet<DanhMuc>();
            HocVus = new HashSet<HocVu>();
            Lops = new HashSet<Lop>();
            Users = new HashSet<User>();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonViID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDonVi { get; set; }

        public virtual ICollection<DanhMuc> DanhMucs { get; set; }
        public virtual ICollection<HocVu> HocVus { get; set; }
        public virtual ICollection<Lop> Lops { get; set; }
        public virtual ICollection<User> Users { get; set; }

        
    }
}
