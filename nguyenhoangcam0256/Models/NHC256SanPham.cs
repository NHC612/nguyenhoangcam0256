using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace nguyenhoangcam0256.Models;
[Table("NHC256SanPham")]
public class NHC256SanPham
{
    [Key]
    public int NHC256SanPhamCode {get; set;}

    public string NHC256NameKhachHang {get; set;}
    [ForeignKey("NHC256NameKhachHang")]
    public NHC256KhachHang? NHC256KhachHang {get; set;}
    public string NHC256TenSanPham {get; set;}

}