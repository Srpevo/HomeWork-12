using HomeWork_12.Core.Enums.Adjust_Visibility_Options;
using System.Reflection;

namespace HomeWork_12.Core.Classes.Ui_Tools
{
    internal static class UiTools
    {
        public static void Clear(params Control[] controls)
        {
            foreach (var control in controls)
                control.Text = string.Empty;
        }

        public static void Clear(ListBox[] listBox)
        {
            foreach (var control in listBox)
                control.Items.Clear();
        }

        private static void AddObjectToListBox<T>(ListBox listBox, T obj) where T : class
        {
            if (obj == null) return;

            Type itemType = obj!.GetType();
            PropertyInfo[] props = itemType.GetProperties();

            listBox.Items.Add($"<{itemType.Name}>");
            foreach (var prop in props)
            {
                listBox.Items.Add($"{prop.Name}: {prop.GetValue(obj)}");
            }
            listBox.Items.Add($"<{itemType.Name}//>");
        }

        public static void AddToList<T>(ListBox listBox, IEnumerable<T> list) where T : class
        {
            if (list == null) return;

            foreach(var item in list)
                AddObjectToListBox(listBox, item);
        }

        public static void AddToList<T>(ListBox listBox, T obj) where T : class
        {
            AddObjectToListBox(listBox, obj);
        }


        public static void ChangeType<Tenum>(ref ComboBox comboBox, out Tenum @enum) where Tenum : struct, Enum
        { 
            string[] names = Enum.GetNames<Tenum>();
            Tenum[] values = (Tenum[])Enum.GetValues(typeof(Tenum));

            @enum = default;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(comboBox.Text, StringComparison.OrdinalIgnoreCase))
                {
                    @enum = values[i];
                    break;
                }
                
            }
        }

        public static void AdjustVisibility(Visibility option, params Control[] controls)
        {
            foreach (var control in controls)
                control.Visible = option == Visibility.Visible;
        }

        public static void ChangeControlText(string[] newText, Control[] controls)
        {
            for (int i = 0; i < controls.Length;i++)
                controls[i].Text = newText[i];
        }

        public static void SetFieldsVisibility(Visibility visibility, string[] labelTexts, Control[] targets, params Control[] controls)
        {
            AdjustVisibility(visibility, controls);
            ChangeControlText(labelTexts, targets);
        }

        public static bool IsEmpty(params Control[] controls)
        {
            bool result = false;
            foreach(var control in controls)
                result = control.Text != string.Empty;
            return result;
        }

        public static bool CheckFields(string message, MessageBoxIcon icon, params Control[] controls)
        {
            if (!IsEmpty(controls))
            {
                MessageBox.Show(message, "message", MessageBoxButtons.OK, icon);
                return false;
            }
            return true;
        }

    }

}

