using System;

namespace KhamBenhMINI.Models
{
    /// <summary>
    /// DTO đóng gói thông tin chẩn đoán theo lượt khám
    /// </summary>
    public class ChuanDoan
    {
        public int MaLuotKham { get; set; }
        public string KetLuan { get; set; } // Tương ứng cột ChanDoan
        public DateTime ThoiGianCapNhat { get; set; }
    }
}