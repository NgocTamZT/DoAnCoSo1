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
        //[Display(Name = "Danh Mục ID")]
        public int DanhMucID { get; set; }
        //[Display(Name = "Tên Danh Mục")]
        [Required]
        [StringLength(50)]
        public string TenDanhMuc { get; set; }

        public int? DonViID { get; set; }

        public virtual DonVi DonVi { get; set; }

        
        public virtual ICollection<HocVu> HocVus { get; set; }
    }
}
