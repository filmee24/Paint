/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Schweiger Simon
 * Datum: 10.12.2006
 * Zeit: 17:19
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */

using System;
using ICSharpCode.Core;

namespace Base.MainMenu
{
	/// <summary>
	/// Beendet das Programm
	/// </summary>
	public class QuitMenuCommand : AbstractMenuCommand
	{
		public override void Run()
		{
			Environment.Exit(0);
		}
		
	}
}
