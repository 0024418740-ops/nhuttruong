
namespace MyCSharpApp.Domain;

public sealed class Instructor
{
    public string Id { get; private set; }
    public string FullName { get; private set; }
    public string Email { get; private set; }

    private Instructor(string id, string fullName, string email)
    {
        Id = id;
        FullName = fullName;
        Email = email;
    }

    public static Instructor Create(
        string id,
        string fullName,
        string email)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException("ID giảng viên không được để trống.");

        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Họ tên không được để trống.");

        if (string.IsNullOrWhiteSpace(email) ||
    !System.Text.RegularExpressions.Regex.IsMatch(
        email.Trim(),
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
{
    throw new ArgumentException("Email không hợp lệ.");
}

        return new Instructor(
            id.Trim(),
            fullName.Trim(),
            email.Trim());
    }
}
