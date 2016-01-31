using ICSharpCode.Core;
using System.Text;

namespace Base
{
    public class Utils
    {
        public static string GetFileFilter(string addInTreePath)
        {
            StringBuilder b = new StringBuilder();
            b.Append("All known file types|");
            foreach (
             string filter in AddInTree.BuildItems(addInTreePath, null, true))
            {
                b.Append(filter.Substring(filter.IndexOf('|') + 1));
                b.Append(';');
            }
            foreach (
             string filter in AddInTree.BuildItems(addInTreePath, null, true))
            {
                b.Append('|');
                b.Append(filter);
            }
            b.Append("|All files|*.*");
            return b.ToString();
        }
    }
}