# EduHub

## Giới thiệu
EduHub là dự án quản lý khóa học, giảng viên, sinh viên và đăng ký khóa học, được phát triển bằng C# và .NET.

## Công nghệ sử dụng
- C#
- .NET
- Git và GitHub

## Cấu trúc dự án
- `Domain/`: Chứa các lớp nghiệp vụ.
- `Docs/`: Chứa tài liệu dự án.
- `Program.cs`: Điểm bắt đầu của chương trình.

## Các lớp nghiệp vụ
- `Course`: Quản lý thông tin khóa học.
- `Instructor`: Quản lý thông tin giảng viên.
- `Students`: Quản lý thông tin sinh viên.
- `Enrollment`: Quản lý đăng ký khóa học.
- `Event`: Quản lý sự kiện.

## Chạy chương trình
Mở Terminal tại thư mục chứa file `.csproj` và chạy:

```bash
dotnet build
dotnet run
```