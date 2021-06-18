using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EXEM_TEST
{
    partial class QLSV
    {
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string path = $"E:\\C# (Sharp)\\C#2\\EXEM_TEST\\EXEM_TEST\\kieu.bin";
        private List<Student> lst;

        private string GHi(List<Student> lstStudents, string path)
        {
            try
            {
                _fs = new FileStream(path,FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs,lstStudents);
                _fs.Close();
                return " ghi file thành công";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
               
            }

            return "ghi file thất bại";
        }

        private List<Student> DOc(string path)
        {
            try
            {
                lst = new List<Student>();
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data=_bf.Deserialize(_fs);
                lst = (List<Student>) data;
                _fs.Close();
                return _lstStudents;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            return null;
        }

        public void docghi()
        {
            do
            {
                input = mes(" chương trình\n" +
                            "1. ghi file\n" +
                            " 2. dọc file\n" +
                            "0. thoát");
                switch (input)
                {
                    case "1": Console.WriteLine(GHi(_lstStudents,path));break;
                    case "2":
                        foreach (var VARIABLE in DOc(path))
                        {
                            VARIABLE.Print_Information("");
                        }

                        ;break;
                    case "0": ;break;
                }

            } while (!(input=="0"));
        }


        
    }
}