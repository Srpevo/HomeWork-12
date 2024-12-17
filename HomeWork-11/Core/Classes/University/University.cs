using HomeWork_12.Core.Classes.Student;

namespace HomeWork_12.Core.Classes.University
{
    internal class University
    {
        public University(int id, string? name, string? description)
        {
            Id = id;
            Name = name;
            Description = description;
            _students = new List<Student.Student>();
        } 

        public University() { }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        private List<Student.Student>? _students;
        public event Action? OnAdd;
        public event Action? OnRemove;

        public List<Student.Student>? Students
        {
            get
            {
                return _students ??= new List<Student.Student>();
            }
            set
            {
                _students = value ?? new List<Student.Student>();
            }
        }

        public void AddStudent(Student.Student student)
        {
            _students?.Add(student);
            OnAdd?.Invoke();
        }
        public void RemoveStudent(int id)
        {
            Student.Student studentToRemove = _students?.Find(x => x.Id == id)!;
            _students?.Remove(studentToRemove);

            OnRemove?.Invoke();
        }
    }
}
