namespace HomeWork_12.Utils.Validators.UniversityValidator
{
    internal static class UniversityValidator
    {
        public static bool CheckUniversityParams(string id, string name, string description)
        {
            try
            {
                return Int32.TryParse(id, out _) &&
                    NameValidator.NameValidator.CheckName(name) &&
                    NameValidator.NameValidator.CheckName(description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
