using System;
using EduHub.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Tạo đối tượng Teacher
        Teacher teacher = new Teacher("T01", "Nguyễn Văn A", "a.nv@eduhub.vn", "Công nghệ phần mềm");

        // Tạo đối tượng Course
        Course course = new Course("CS101", "Nhập môn Lập trình C#", 3);

        // In thông tin ra màn hình
        Console.WriteLine("=== THÔNG TIN EDUHUB ===");
        Console.WriteLine($"Giảng viên: {teacher.Name} - Chuyên ngành: {teacher.Major}");
        Console.WriteLine($"Khóa học: {course.Title} (Mã: {course.CourseId}) - Số tín chỉ: {course.Credits}");
    }
}