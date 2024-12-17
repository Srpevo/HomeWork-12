using HomeWork_12.Core.Classes.University;

namespace HomeWork_12.Utils.Validators.StudentValidator
{
    internal static class StudentValidator
    {
        private static bool CheckUniversities(string studentUniversity, List<University> universities)
        {
            foreach (var univer in universities)
                if (univer.Name == studentUniversity)
                    return true;

            return false;
        }

        public static bool CheckStudentParams(string id, string name, string surname, string email, string password, string studentUniversity, List<University> universities)
        {
            try
            {
                return Int32.TryParse(id, out _) &&
                    NameValidator.NameValidator.CheckName(name) &&
                    NameValidator.NameValidator.CheckName(surname) &&
                    EmailValidator.EmailValidator.CheckEmail(email) &&
                    CheckUniversities(studentUniversity, universities) &&
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
