using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Student
{
    internal class DSSV
    {
        public class Student
        {
            public int Id { get; set; }
            public String Name { get; set; }
            public int Age { get; set; }
            public Student() { }
            public Student(int id, String name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }

        }

        static void Main(string[] args)
        {
            List<Student> s = new List<Student>
        {
            new Student(01, "Pham Minh Nhat", 16),
            new Student(02, "Anh Phan Huy", 17),
            new Student(03, "Tran Minh Hieu", 18),
            new Student(04, "Pham Thanh An",19),
            new Student(05, "Phan Van Hai", 20)
        };
            // In danh sách toàn bộ danh sách học sinh
            Console.WriteLine("A) Danh sach hoc sinh");
            s.ForEach(x => Console.WriteLine($"Ma so : {x.Id}, Ten hoc sinh: {x.Name}, Tuoi hoc sinh: {x.Age}"));
            // Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18.
            var Search = s.Where(st => st.Age >= 15 && st.Age <= 18).ToList();
            Console.WriteLine("\nB) Danh sach hoc sinh tu 15 đen 18 tuoi");
            Search.ForEach(st => Console.WriteLine($"Ma so : {st.Id}, Ten hoc sinh: {st.Name}, Tuoi hoc sinh: {st.Age}"));
            //Tìm và in ra học sinh có tên bắt đầu bằng chữ "A".
            var fla = s.Where(st => st.Name.StartsWith("A")).ToList();
            if (fla.Count > 0)
            {
                Console.WriteLine("\nC) Hoc sinh co ten bat dau bang chu 'A'");
                fla.ForEach(st => Console.WriteLine($"Ma so : {st.Id}, Ten hoc sinh: {st.Name}, Tuoi hoc sinh: {st.Age}"));
            }
            else
            {
                Console.WriteLine("-> Khong co hoc sinh nao co ten bat dau bang chu 'A'");
            }
            //Tính tổng tuổi của tất cả học sinh trong danh sách.
            Console.WriteLine("\nD) Tong tuoi cua tat ca hoc sinh");
            int TotalAge = s.Sum(st => st.Age);
            Console.WriteLine("-> Tong tuoi cua tat ca hoc sinh la: " + TotalAge);
            //Tìm và in ra học sinh có tuối lớn nhất.
            Console.WriteLine("\nE) Hoc sinh co tuoi lon nhat");
            var MaxAge = s.OrderByDescending(st => st.Age).First();
            Console.WriteLine($"Ma so : {MaxAge.Id}, Ten hoc sinh: {MaxAge.Name}, Tuoi hoc sinh: {MaxAge.Age}");
            //Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp.
            Console.WriteLine("\nF) Sap xep danh sach hoc sinh theo tuoi tang dan");
            var RankAge = s.OrderBy(st => st.Age);
            foreach (var student in RankAge)
            {
                Console.WriteLine($"Ma so hoc sinh: {student.Id}, Ten hoc sinh: {student.Name}, Tuoi hoc sinh: {student.Age}");
            }

            Console.ReadLine();
        }
    }

}