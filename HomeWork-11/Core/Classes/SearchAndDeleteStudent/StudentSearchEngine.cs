namespace HomeWork_12.Core.Classes.SearchAndDeleteStudent
{
    internal static class StudentSearchEngine
    {
        public static void FindAndClearStudent(List<University.University> universities, Func<University.University, bool> searchFunc, int studentId)
        {
            var univer = universities.FirstOrDefault(searchFunc);
            if (univer == null) return;
            univer.RemoveStudent(studentId);
        }
    }
}
