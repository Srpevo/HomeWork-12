using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12.Core.Classes.Folder_Explorer
{
    internal static class FolderExplorer
    {
        public static string GetPath(string fileName)
        {
            using (FolderBrowserDialog dialog = new())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    return Path.Combine(dialog.SelectedPath, fileName);
                else
                    return string.Empty;
            }
        }
    }
}
