using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace testcsdl.Table
{
    public partial class DanhMuc
    {
        
        public DanhMuc()
        {
            HocVus = new HashSet<HocVu>();
        }
        
        public int DanhMucID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string TenDanhMuc { get; set; }

        public int? DonViID { get; set; }

        public virtual DonVi DonVi { get; set; }

        
        public virtual ICollection<HocVu> HocVus { get; set; }
    }
}
