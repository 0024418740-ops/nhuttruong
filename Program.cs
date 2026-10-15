
using MyCSharpApp.Domain;

Console.WriteLine("              ");
Console.WriteLine("       EDUHUB - CONSOLE DEMO CH01");
Console.WriteLine("              ");

// 1. Tạo khóa học
var course = Course.Create(
    "C001",
    "Lập trình C#",
    30);

// 2. Tạo sinh viên
var student = Student.Create(
    "S001",
    "Nguyen Van An",
    "an@example.com");

// 3. Tạo giảng viên
var instructor = Instructor.Create(
    "I001",
    "Tran Thi Binh",
    "binh@example.com");

// 4. Tạo sự kiện
var eduEvent = Event.Create(
    "E001",
    "Buoi hoc C# so 1",
    course.Id,
    instructor.Id,
    DateTime.Now.AddDays(1));

// 5. Tạo đăng ký
var enrollment = Enrollment.Create(
    "EN001",
    student.Id,
    course.Id);

Console.WriteLine("\nTHONG TIN KHOA HOC");
Console.WriteLine($"Ma khoa hoc: {course.Id}");
Console.WriteLine($"Ten khoa hoc: {course.Title}");
Console.WriteLine($"Suc chua: {course.Capacity}");

Console.WriteLine("\nTHONG TIN SINH VIEN");
Console.WriteLine($"Ma sinh vien: {student.Id}");
Console.WriteLine($"Ho ten: {student.FullName}");
Console.WriteLine($"Email: {student.Email}");

Console.WriteLine("\nTHONG TIN GIANG VIEN");
Console.WriteLine($"Ma giang vien: {instructor.Id}");
Console.WriteLine($"Ho ten: {instructor.FullName}");
Console.WriteLine($"Email: {instructor.Email}");

Console.WriteLine("\n THONG TIN SU KIEN");
Console.WriteLine($"Ma su kien: {eduEvent.Id}");
Console.WriteLine($"Ten su kien: {eduEvent.Title}");
Console.WriteLine($"Thoi gian: {eduEvent.StartAt:dd/MM/yyyy HH:mm}");
Console.WriteLine($"Khoa hoc: {eduEvent.CourseId}");
Console.WriteLine($"Giang vien: {eduEvent.InstructorId}");

Console.WriteLine("\nQUY TRINH DANG KY");
Console.WriteLine($"Trang thai ban dau: {enrollment.Status}");

enrollment.Activate();
Console.WriteLine($"Sau khi kich hoat: {enrollment.Status}");

enrollment.Complete();
Console.WriteLine($"Sau khi hoan thanh: {enrollment.Status}");

Console.WriteLine("\n KIEM TRA QUY TAC NGHIEP VU");

try
{
    enrollment.Activate();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Loi dung quy tac: {ex.Message}");
}

// 7. In báo cáo tham dự
Console.WriteLine("\n BAO CAO ");
Console.WriteLine($"Sinh vien: {student.FullName}");
Console.WriteLine($"Khoa hoc: {course.Title}");
Console.WriteLine($"Trang thai dang ky: {enrollment.Status}");
Console.WriteLine("KET THUC DEMO");
