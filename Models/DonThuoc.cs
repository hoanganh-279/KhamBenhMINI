namespace KhamBenhMINI
{
    /// <summary>
    /// Model đại diện cho bảng DonThuoc
    /// </summary>
    public class DonThuoc
    {
        public int MaDonThuoc { get; set; }
        public int MaLuotKham { get; set; }
        public int MaThuoc { get; set; }
        public int SoLuong { get; set; }
        public string CachDung { get; set; }

        // 🔹 Properties hỗ trợ hiển thị dữ liệu JOIN trên UI
        public string TenThuoc { get; set; }
        public string DonViTinh { get; set; }
    }
}