using System.ComponentModel.DataAnnotations;
namespace nguyenhoangcam0256.Models;

public class NHC256KhachHang
{
    [Key]
    public int NHC256KhachHangID {get; set;}

    public string NHC256NameKhachHang {get; set;}
    public float NHC256Address {get; set;}

}