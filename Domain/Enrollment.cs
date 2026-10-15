
namespace MyCSharpApp.Domain;

public enum EnrollmentStatus
{
    Pending,
    Active,
    Completed,
    Cancelled
}

public sealed class Enrollment
{
    public string Id { get; private set; }
    public string StudentId { get; private set; }
    public string CourseId { get; private set; }
    public EnrollmentStatus Status { get; private set; }

    private Enrollment(
        string id,
        string studentId,
        string courseId)
    {
        Id = id;
        StudentId = studentId;
        CourseId = courseId;
        Status = EnrollmentStatus.Pending;
    }

    public static Enrollment Create(
        string id,
        string studentId,
        string courseId)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException(
                "Enrollment ID không được để trống.");

        if (string.IsNullOrWhiteSpace(studentId))
            throw new ArgumentException(
                "Student ID không được để trống.");

        if (string.IsNullOrWhiteSpace(courseId))
            throw new ArgumentException(
                "Course ID không được để trống.");

        return new Enrollment(
            id.Trim(),
            studentId.Trim(),
            courseId.Trim());
    }

    public void Complete()
    {
        if (Status != EnrollmentStatus.Active)
            throw new InvalidOperationException(
                "Chỉ đăng ký đang hoạt động mới được hoàn thành.");

        Status = EnrollmentStatus.Completed;
    }
    public void Activate()
{
    if (Status != EnrollmentStatus.Pending)
        throw new InvalidOperationException(
            "Chỉ đăng ký đang chờ mới được kích hoạt.");

    Status = EnrollmentStatus.Active;
}
}

