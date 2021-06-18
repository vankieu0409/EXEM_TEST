using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EXEM_TEST
{ //Tạo Class QLSV sử dụng List<SinhVien>, code các chức năng tại đây như (Tạo sẵn 5 đối tượng ảo) - (0.5 điểm)
    //Program.cs Tạo Menu sử dụng SwitchCase  và gán các chức năng bên Class QLSV sang.
    //Viết chương trình thực hiện việc quản lý như menu sau(Switch Case – Loop) : (0.5 điểm)

    //2. Xuất 1 đối tượng hoặc danh sách đối tượng bao gồm tuổi(0.5 điểm)
    //3. Lưu File - Đọc File(2điểm)
    //5. Xóa đối tượng theo mã do người dùng nhập sử dụng LINQ(1 điểm)
    //6. Sử dụng LINQ lọc những người có tuổi >20 và điểm Csharp >=5 và tên có chữ T(1 điểm)
    //7. Sắp xếp giảm dần danh sách sử dụng LINQ(1 điểm)
    //0.Thoát
    //Bài có check trùng mã sinh viên khi nhập vào và check rỗng(1 điểm)
    partial class QLSV
    {
        private List<Student> _lstStudents;
        private string input;
        private Student sv;

        public QLSV()
        {
            _lstStudents = new List<Student>();
            Student sv1 = new Student(1, "Kiều", 1998, 10, 1);
            Student sv2 = new Student(2, "Trang", 1998, 10, 2);
            Student sv3 = new Student(3, "Lưu", 1998, 10, 1);
            Student sv4 = new Student(4, "Phương", 1998, 10, 1);
            Student sv5 = new Student(1, "Hải", 1998, 10, 2);
            _lstStudents.Add(sv1);
            _lstStudents.Add(sv2);
            _lstStudents.Add(sv3);
            _lstStudents.Add(sv4);
            _lstStudents.Add(sv5);
        }

        public string mes(string mes)
        {
            Console.Write(" mời bạn Nhập " + mes);
            return Console.ReadLine();
        }

        //1. Nhập danh sách đối tượng(1 điểm )
        public void them()
        {
            int sl = Int32.Parse(mes(" Số lượng DS SV: "));
            for (int i = 0; i < sl; i++)
            {
                string a;
                sv = new Student();


                do
                {
                    a = mes("Mã Sinh viên: ");
                } while (check(a));

                sv.MaSv = Convert.ToInt16(a);
                sv.Name = mes(" Tên Sinh Viên: ");
                sv.NamSinh = Convert.ToInt32(mes(" Năm Sinh: "));
                sv.Sex = Convert.ToInt16(mes("  giới tính: 1- Nam; 2- Nữ : "));
                sv.DiemCsHarp = float.Parse(mes(" điểm: "));
                _lstStudents.Add(sv);
            }
        }

        private bool check(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine(" bạn đã để trống Mã SV. hãy Nhập lại");
                return true;
            }

            if (Regex.IsMatch(text, @"^\d+$") == false)
            {
                Console.WriteLine(" Bạn Phải Nhập số!  ");
                return true;
            }

            for (int j = 0; j < _lstStudents.Count; j++)
            {
                if (Convert.ToInt16(text) == (_lstStudents[j].MaSv))
                {
                    Console.WriteLine(" Mã Sinh viên đã có. vui lòng chọ số khác");
                    return true;
                }
            }


            return false;
        }

        //2. Xuất 1 đối tượng hoặc danh sách đối tượng bao gồm tuổi(0.5 điểm)
        public void PrintTuoi()
        {
            foreach (var x in _lstStudents)
            {
                x.Print_Information($"{2021 - x.NamSinh} tuổi");
            }
        }

        //3. Lưu File - Đọc File(2điểm)
        //5. Xóa đối tượng theo mã do người dùng nhập sử dụng LINQ(1 điểm)

        public void XoaLINQ()
        {
            input = mes("Mã SV cần xóa: ");
            foreach (var x in _lstStudents.Where(c => c.MaSv == Convert.ToInt16(input)))
            {
                int i = 0;
                if (x.MaSv == _lstStudents[i].MaSv)
                {
                    _lstStudents.RemoveAt(i);
                }
            }
        }

        //6. Sử dụng LINQ lọc những người có tuổi >20 và điểm Csharp >=5 và tên có chữ T(1 điểm)
        public void LocDiemTuoi()
        {
            foreach (var x in _lstStudents.Where(c => c.NamSinh < 2001 && c.DiemCsHarp > 5))
            {
                x.Print_Information("");
            }
        }

        //7. Sắp xếp giảm dần danh sách sử dụng LINQ(1 điểm)
        public void SAPXEPgiam()
        {
            foreach (var x in _lstStudents.OrderByDescending(c => c.MaSv))
            {
                x.Print_Information("");
            }
        }
        //0.Thoát
        //Bài có check trùng mã sinh viên khi nhập vào và check rỗng(1 điểm)
    }
}