using System.Data;

namespace KhamBenhMINI.DAL
{
    public class ThuocDAL
    {
        public DataTable GetAll()
        {
            return Database.ExecuteQuery("SELECT MaThuoc, TenThuoc, DonViTinh FROM Thuoc ORDER BY TenThuoc");
        }
    }
}