using Dtb_Lesson01;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dtb_Lesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(
                    "001",
                    "Nguyen Van An",
                    new DateTime(2005, 1, 10),
                    "Nam",
                    "an@gmail.com",
                    "0123456789",
                    "CNTT",
                    8.5,
                    "Đang học"
                ),

                new Student(
                    "002",
                    "Tran Thi Binh",
                    new DateTime(2005, 5, 20),
                    "Nu",
                    "binh@gmail.com",
                    "0123456790",
                    "Ke toan",
                    7.2,
                    "Đang học"
                ),

                new Student(
                    "003",
                    "Le Van Cuong",
                    new DateTime(2004, 8, 15),
                    "Nam",
                    "cuong@gmail.com",
                    "0123456791",
                    "CNTT",
                    9.1,
                    "Đang học"
                ),

                new Student(
                    "004",
                    "Pham Thi Dung",
                    new DateTime(2005, 3, 12),
                    "Nu",
                    "dung@gmail.com",
                    "0123456792",
                    "Marketing",
                    6.8,
                    "Bao luu"
                ),

                new Student(
                    "005",
                    "Hoang Van Em",
                    new DateTime(2004, 11, 5),
                    "Nam",
                    "em@gmail.com",
                    "0123456793",
                    "CNTT",
                    9.1,
                    "Đang học"
                )
            };

            string choice;

            do
            {
                Menu();

                Console.Write("Nhap lua chon: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(students);
                        break;

                    case "2":
                        DisplayStudents(students);
                        break;

                    case "3":
                        FindStudentById(students);
                        break;

                    case "4":
                        SearchStudentByName(students);
                        break;

                    case "5":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "6":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "7":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "8":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "9":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "10":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "11":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "12":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "13":
                        Console.WriteLine("Chuc nang dang phat trien...");
                        break;

                    case "14":
                        Console.WriteLine("Ban da ket thuc chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Sai chuc nang, vui long chon lai!");
                        break;
                }

                Console.WriteLine();

            } while (choice != "14");
        }


        // ================= MENU =================

        static void Menu()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("       CHUONG TRINH QUAN LY SINH VIEN");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Hien thi danh sach sinh vien");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim gan dung theo ho ten");
            Console.WriteLine("5. Cap nhat sinh vien");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo ho ten");
            Console.WriteLine("8. Sap xep theo diem trung binh");
            Console.WriteLine("9. Hien thi sinh vien co diem tu 8 tro len");
            Console.WriteLine("10. Hien thi sinh vien co diem cao nhat");
            Console.WriteLine("11. Tinh diem trung binh");
            Console.WriteLine("12. Thong ke sinh vien theo nganh");
            Console.WriteLine("13. Thong ke sinh vien theo trang thai");
            Console.WriteLine("14. Thoat");
            Console.WriteLine("==========================================");
        }


        // ================= THEM SINH VIEN =================

        static void AddStudent(List<Student> students)
        {
            Console.WriteLine("===== THEM SINH VIEN =====");

            Console.Write("Nhap ma sinh vien: ");
            string mssv = Console.ReadLine();

            if (students.Any(x => x.mssv == mssv))
            {
                Console.WriteLine("Ma sinh vien da ton tai!");
                return;
            }

            Console.Write("Nhap ho ten: ");
            string name = Console.ReadLine();

            Console.Write("Nhap ngay sinh (yyyy-MM-dd): ");
            DateTime? ngaysinh = null;

            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                ngaysinh = date;
            }

            Console.Write("Nhap gioi tinh: ");
            string gioiTinh = Console.ReadLine();

            Console.Write("Nhap email: ");
            string email = Console.ReadLine();

            Console.Write("Nhap so dien thoai: ");
            string soDienThoai = Console.ReadLine();

            Console.Write("Nhap nganh hoc: ");
            string nganhHoc = Console.ReadLine();

            Console.Write("Nhap diem trung binh: ");
            double.TryParse(Console.ReadLine(), out double diemTrungBinh);

            Console.Write("Nhap trang thai hoc tap: ");
            string trangThaiHocTap = Console.ReadLine();

            Student student = new Student(
                mssv,
                name,
                ngaysinh,
                gioiTinh,
                email,
                soDienThoai,
                nganhHoc,
                diemTrungBinh,
                trangThaiHocTap
            );

            students.Add(student);

            Console.WriteLine("Them sinh vien thanh cong!");
        }


        // ================= HIEN THI =================

        static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("===== DANH SACH SINH VIEN =====");

            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach sinh vien dang rong.");
                return;
            }

            foreach (Student student in students)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Ma SV: " + student.mssv);
                Console.WriteLine("Ho ten: " + student.name);
                Console.WriteLine("Ngay sinh: " + student.Ngaysinh?.ToString("dd/MM/yyyy"));
                Console.WriteLine("Gioi tinh: " + student.GioiTinh);
                Console.WriteLine("Email: " + student.Email);
                Console.WriteLine("So dien thoai: " + student.SoDienThoai);
                Console.WriteLine("Nganh hoc: " + student.NganhHoc);
                Console.WriteLine("Diem trung binh: " + student.DiemTrungBinh);
                Console.WriteLine("Trang thai: " + student.TrangThaiHocTap);
            }

            Console.WriteLine("------------------------------------------");
        }


        // ================= TIM THEO MA =================

        static void FindStudentById(List<Student> students)
        {
            Console.WriteLine("===== TIM SINH VIEN THEO MA =====");

            Console.Write("Nhap ma sinh vien: ");
            string mssv = Console.ReadLine();

            Student student = students.FirstOrDefault(x => x.mssv == mssv);

            if (student == null)
            {
                Console.WriteLine("Khong tim thay sinh vien.");
                return;
            }

            Console.WriteLine("Tim thay sinh vien:");

            Console.WriteLine("Ma SV: " + student.mssv);
            Console.WriteLine("Ho ten: " + student.name);
            Console.WriteLine("Ngay sinh: " + student.Ngaysinh?.ToString("dd/MM/yyyy"));
            Console.WriteLine("Gioi tinh: " + student.GioiTinh);
            Console.WriteLine("Email: " + student.Email);
            Console.WriteLine("So dien thoai: " + student.SoDienThoai);
            Console.WriteLine("Nganh hoc: " + student.NganhHoc);
            Console.WriteLine("Diem trung binh: " + student.DiemTrungBinh);
            Console.WriteLine("Trang thai: " + student.TrangThaiHocTap);
        }


        // ================= TIM GAN DUNG THEO TEN =================

        static void SearchStudentByName(List<Student> students)
        {
            Console.WriteLine("===== TIM GAN DUNG THEO HO TEN =====");

            Console.Write("Nhap ho ten can tim: ");
            string keyword = Console.ReadLine();

            var result = students
                .Where(x => x.name.Contains(
                    keyword,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("Khong tim thay sinh vien.");
                return;
            }

            Console.WriteLine("Ket qua tim kiem:");

            foreach (Student student in result)
            {
                Console.WriteLine(
                    student.mssv + " - " +
                    student.name + " - " +
                    student.NganhHoc + " - " +
                    student.DiemTrungBinh
                );
            }
        }
    }
}