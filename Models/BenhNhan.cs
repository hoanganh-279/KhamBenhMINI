using System;

namespace KhamBenhMINI
{
    /// <summary>
    /// Model đại diện cho bảng BenhNhan
    /// </summary>
    public class BenhNhan
    {
        public int MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayTao { get; set; }
    }
}