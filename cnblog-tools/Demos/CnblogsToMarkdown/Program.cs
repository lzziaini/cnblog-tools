using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Common.Helper;
using Html2Markdown;

namespace CnblogsToMarkdown
{
    internal class Program
    {
		private static void Main(string[] args)
		{
			//Init
			if (!Directory.Exists(Application.StartupPath + "\\output\\"))
			{
				Directory.CreateDirectory(Application.StartupPath + "\\output\\");
			}

			if (!Directory.Exists(Application.StartupPath + "\\images\\"))
			{
				Directory.CreateDirectory(Application.StartupPath + "\\images\\");
			}

            CnblogHtmlHelper.ExportToMarkdown("q787011187", 0, 10, true, "http://q787011187.com/blog/images/");


			Console.WriteLine("All the Articles are generated successfully!Press any key to quit..");
			Console.Read();
		}
	}
}