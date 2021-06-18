using System;

namespace EXEM_TEST
{//Tạo Class SinhVien bao gồm các thuộc tính: MaSV – int, Ten – string, NamSinh – int – ,
 //DiemCsharp - float,GioiTinh int (1 – Nam | 2- Nữ) float inThongTin():void -
 //(Đối với class Private các thuộc tính, Property, Contructor có tham số và không tham số) - (0.5 điểm)
    [Serializable]
    public class Student
    {
        private int maSv;
        private string name;
        private int namSinh;
        private float diemCSHarp;
        private int sex;

        public Student()
        {

        }

        public Student(int maSv, string name, int namSinh, float diemCsHarp, int sex)
        {
            this.maSv = maSv;
            this.name = name;
            this.namSinh = namSinh;
            diemCSHarp = diemCsHarp;
            this.sex = sex;
        }

        public int MaSv
        {
            get => maSv;
            set => maSv = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public float DiemCsHarp
        {
            get => diemCSHarp;
            set => diemCSHarp = value;
        }

        public int Sex
        {
            get => sex;
            set => sex = value;
        }

        public void Print_Information(string m)
        {
            Console.WriteLine("MÃ SV: {0}|| Tên SV: {1} || Năm Sinh: {2}|| Giới tính: {3}|| Điểm C#: {4}|| {5}", maSv, name, namSinh, (sex == 1) ? "Nam" : (sex == 2) ? "Nữ" : "", diemCSHarp,m);
        }
    }
}