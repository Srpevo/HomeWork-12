using HomeWork_12.Core.Classes.Ui_Tools;

namespace HomeWork_12.Core.Classes.Search_Engine
{
    internal static class SearchEngine
    {
        public static void FindObject<T>(ref ListBox resultBox, List<T> list, Func<T, bool> func) where T : class
        {

            var items = list.Where(func);

            if (items == null) { return; }

            UiTools.AddToList(resultBox, items);
        }


        public static void FindObject<T, S>(ref ListBox resultBox, List<T> list, Func<T, IEnumerable<S>> nestedSelector)
            where T : class
            where S : class
        {
            var items = list.SelectMany(nestedSelector);

            if (items == null) { return; }

            UiTools.AddToList(resultBox, items);
        }
    }
}
