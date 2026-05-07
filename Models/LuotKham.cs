using System;

namespace KhamBenhMINI.Models
{
    /// <summary>
    /// Model đại diện cho bảng LuotKham
    /// </summary>
    public class LuotKham
    {
        public int MaLuotKham { get; set; }
        public int MaBenhNhan { get; set; }
        public int MaBacSi { get; set; }
        public DateTime NgayKham { get; set; }
        public string TrieuChung { get; set; }
        public string ChanDoan { get; set; }
        public string HuongXuTri { get; set; }
        public string GhiChu { get; set; }

        // 🔹 Properties hỗ trợ hiển thị dữ liệu JOIN trên UI (không lưu vào DB)
        public string TenBenhNhan { get; set; }
        public string TenBacSi { get; set; }
    }
}