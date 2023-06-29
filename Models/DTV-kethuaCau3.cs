using System.ComponentModel.DataAnnotations;

namespace BaiThi_DTV
{
    public class LopHoc
    {
        [Key]
        public string MaSV { get; set; }

        public string TenSV { get; set; }

        public string Adress { get; set; }

        public string SDT { get; set; }
        
        public string Lop { get; set; }

    }
}