using ICSharpCode.Core;
using System.Windows.Forms;

namespace TestAddIn
{
	public class TestItem : AbstractMenuCommand
	{
		public override void Run()
		{
			MessageBox.Show("The TestAddIn says: Hello World");
		}
	}
}