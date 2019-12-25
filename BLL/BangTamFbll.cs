using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.Bang_tam_giang_day;
using System.Data;

namespace BLL
{
    public class BangTamFbll
    {
        FunctionBangTamAccess FakeTable = new FunctionBangTamAccess();
        //Thêm mới thông tin
        public void Insert(string magv,string malophp,string sotiet, string ghichu)
        {
            FakeTable.Insert(magv,malophp,sotiet, ghichu);
        }

        //Hiển thị thông tin
        public DataTable HienThi(string magv, string LoaiHinhDT)
        {
            return FakeTable.HienThi(magv, LoaiHinhDT);
        }

        //Lấy ra mã lớp hp trong hệ thống giống mã lớp hp điều kiện 
        public string getAllMaLopHP(string malophp)
        {
            return FakeTable.getAllMaLopHP(malophp);
        }

        //Lấy ra mã lớp trong 1 phiên làm việc của 1 gv để kiểm tra xem lớp gv nhập đã tồn tại hay chưa
        public string getMaLopHP(string malopHP, string magv)
        {
            return FakeTable.getMaLopHP(malopHP, magv);
        }

        //Xóa thông tin
        public void Delete(string malophp)
        {
            FakeTable.Delete(malophp);
        }

        //Update thông tin
        public void Edit(string magv, string malophp, string sotiet, string ghichu)
        {
            FakeTable.Edit(magv, malophp, sotiet, ghichu);
        }
    }
}
