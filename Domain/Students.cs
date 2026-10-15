
namespace MyCSharpApp.Domain;

public sealed class Student
{
    public string Id { get; private set; }
    public string FullName { get; private set; }
    public string Email { get; private set; }

    private Student(string id, string fullName, string email)
    {
        Id = id;
        FullName = fullName;
        Email = email;
    }

    public static Student Create(string id, string fullName, string email)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException("ID sinh viên không được để trống.");

        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Họ tên sinh viên không được để trống.");

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email sinh viên không được để trống.");
            if (!System.Text.RegularExpressions.Regex.IsMatch(
        email.Trim(),
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            throw new ArgumentException("Email sinh viên không hợp lệ.");
        }

        return new Student(id.Trim(), fullName.Trim(), email.Trim());
    }
}
