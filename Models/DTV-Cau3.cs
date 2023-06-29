using System.ComponentModel.DataAnnotations;

namespace BaiThi_DTV
{
    public class LopHoc
    {
        [Key]
        public string MaSV { get; set; }
        [Display (Name ="Ma sinh vien")]
        public string TenSV { get; set; }
        [Display (Name ="Ho Ten")]
        public string Adress { get; set; }
        [Display (Name ="Dia Chi")]
    }
}