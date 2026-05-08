using System;
namespace KhamBenhMINI
{
    /// <summary>
    /// DTO đóng gói thông tin triệu chứng theo lượt khám
    /// </summary>
    public class TrieuChung
    {
        public int MaLuotKham { get; set; }
        public string MoTa { get; set; } // Tương ứng cột TrieuChung
        public DateTime ThoiGianCapNhat { get; set; }
    }
}