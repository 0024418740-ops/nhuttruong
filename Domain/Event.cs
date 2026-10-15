
namespace MyCSharpApp.Domain;

public sealed class Event
{
    public string Id { get; private set; }
    public string Title { get; private set; }
    public string CourseId { get; private set; }
    public string InstructorId { get; private set; }
    public DateTime StartAt { get; private set; }

    private Event(
        string id,
        string title,
        string courseId,
        string instructorId,
        DateTime startAt)
    {
        Id = id;
        Title = title;
        CourseId = courseId;
        InstructorId = instructorId;
        StartAt = startAt;
    }

    public static Event Create(
        string id,
        string title,
        string courseId,
        string instructorId,
        DateTime startAt)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException(
                "ID sự kiện không được để trống.");

        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException(
                "Tên sự kiện không được để trống.");

        if (string.IsNullOrWhiteSpace(courseId))
            throw new ArgumentException(
                "Course ID không được để trống.");

        if (string.IsNullOrWhiteSpace(instructorId))
            throw new ArgumentException(
                "Instructor ID không được để trống.");

        if (startAt == default)
            throw new ArgumentException(
                "Thời gian bắt đầu không hợp lệ.");

        return new Event(
            id.Trim(),
            title.Trim(),
            courseId.Trim(),
            instructorId.Trim(),
            startAt);
    }
}
