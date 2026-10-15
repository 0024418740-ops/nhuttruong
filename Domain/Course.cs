
namespace MyCSharpApp.Domain;

public sealed class Course
{
    public string Id { get; private set; }
    public string Title { get; private set; }
    public int Capacity { get; private set; }

    private Course(string id, string title, int capacity)
    {
        Id = id;
        Title = title;
        Capacity = capacity;
    }

    public static Course Create(
        string id,
        string title,
        int capacity)
    {
        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException("ID không được để trống.");

        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Tên khóa học không được để trống.");

        if (capacity <= 0)
            throw new ArgumentException("Sức chứa phải lớn hơn 0.");

        return new Course(id.Trim(), title.Trim(), capacity);
    }
}
