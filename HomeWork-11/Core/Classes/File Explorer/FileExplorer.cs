using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12.Core.Classes.File_Explorer
{
    internal static class FileExplorer
    {
        public static string GetPath()
        {
            using (OpenFileDialog dialog = new())
            {
                dialog.Filter = "(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                    return dialog.FileName;
                else
                    return null!;
            }
        }
    }
}
