namespace task02;

public class StudentService
{
    private readonly List<Student> _students;

    public StudentService(List<Student> students) => _students = students;

    // 1. Возвращает студентов указанного факультета
    public IEnumerable<Student> GetStudentsByFaculty(string faculty)
        => _students.Where(c => c.Faculty == faculty);

    // 2. Возвращает студентов со средним баллом >= minAverageGrade
    public IEnumerable<Student> GetStudentsWithMinAverageGrade(double minAverageGrade)
        => _students.Where(c => c.Grades.Average() >= minAverageGrade);

    // 3. Возвращает студентов, отсортированных по имени (A-Z)
    public IEnumerable<Student> GetStudentsOrderedByName()
        => _students.OrderBy(c => c.Name);

    // 4. Группировка по факультету
    public ILookup<string, Student> GroupStudentsByFaculty()
        => _students.ToLookup(c => c.Faculty);

    // 5. Находит факультет с максимальным средним баллом
    public string GetFacultyWithHighestAverageGrade()
        => _students.GroupBy(c => c.Faculty).Select(c => new {Faculty=c.Key, Grage=c.Average(g=>g.Grades.Average())}).OrderByDescending(c=>c.Grage).First().Faculty;
}
