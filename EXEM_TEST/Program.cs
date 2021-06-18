using System;
using System.Text;

namespace EXEM_TEST
{
    //Tạo Class SinhVien bao gồm các thuộc tính: MaSV – int, Ten – string, NamSinh – int – , DiemCsharp,GioiTinh int (1 – Nam | 2- Nữ) float inThongTin():void - (Đối với class Private các thuộc tính, Property, Contructor có tham số và không tham số) - (0.5 điểm)
    //Tạo Class QLSV sử dụng List<SinhVien>, code các chức năng tại đây như (Tạo sẵn 5 đối tượng ảo) - (0.5 điểm)
    //Program.cs Tạo Menu sử dụng SwitchCase  và gán các chức năng bên Class QLSV sang.
    //Viết chương trình thực hiện việc quản lý như menu sau(Switch Case – Loop) : (0.5 điểm)
    //1. Nhập danh sách đối tượng(1 điểm )
    //2. Xuất 1 đối tượng hoặc danh sách đối tượng bao gồm tuổi(0.5 điểm)
    //3. Lưu File - Đọc File(2điểm)
    //5. Xóa đối tượng theo mã do người dùng nhập sử dụng LINQ(1 điểm)
    //6. Sử dụng LINQ lọc những người có tuổi >20 và điểm Csharp >=5 và tên có chữ T(1 điểm)
    //7. Sắp xếp giảm dần danh sách sử dụng LINQ(1 điểm)
    //0.Thoát
    //Bài có check trùng mã sinh viên khi nhập vào và check rỗng(1 điểm)
    //Trong bài thi có dùng Partial Class có trả về giá trị / Vấn đáp code(1đ)

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            QLSV pt = new QLSV();
            string lenh;
            do
            {
                Console.WriteLine("1. thêm\n" +
                                  " 2. in ra\n" +
                                  " 3. xóa\n" +
                                  " 4. doc ghi\n" +
                                  " 5. loc\n" +
                                  " 6.sắp xếp giảm dần");
                lenh= Console.ReadLine();
                switch (lenh)
                {
                    case "1":pt.them();break;
                    case "2":pt.PrintTuoi();break;
                    case "3":pt.XoaLINQ();break;
                    case "4":pt.docghi();break;
                    case "5":pt.LocDiemTuoi();break;
                    case "6":pt.SAPXEPgiam();break;
                    case "0":Environment.Exit(0); break;
                    default: Console.WriteLine("ahdfjkadhf");break;
                }
            } while (true);
        }
    }
}
