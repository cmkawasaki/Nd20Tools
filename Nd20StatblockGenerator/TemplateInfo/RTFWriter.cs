using System;
using System.IO;

namespace Nd20TemplateLib
{
	/// <summary>
	/// Summary description for RTFWriter.
	/// </summary>
	public class RTFWriter
	{
		private string MyFileName;
		private StreamWriter Tex;
		
		public RTFWriter(string Filename)
		{
			MyFileName = Filename;
		}

		public void Open()
		{
			FileInfo FileName = new FileInfo(MyFileName);
			Tex = FileName.CreateText();
			Tex.WriteLine("{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fswiss\\fcharset0 Times New Roman;}}");
			Tex.WriteLine("{\\*\\generator Msftedit 5.41.15.1507;}\\viewkind4\\uc1\\pard\\f0\\fs24 ");

		} //End of Open()

		public void Close()
		{
			Tex.Write("}");
			Tex.Close();
		}

		public void Write(string myString)
		{
			Tex.Write(myString);
		}

		public void WriteBold(string myString)
		{
			string lString = "\\b " + myString + "\\b0 ";
			Tex.Write(lString);
		}

		public void WriteItalics(string myString)
		{
			string lString = "\\i " + myString + "\\i0 ";
			Tex.Write(lString);
		}

		public void WriteLine(string myString)
		{
			Tex.WriteLine(myString + "\\par");
		}

		public void InsertReturn()
		{
			Tex.WriteLine("\\par");
		}

        public static string FormatWithBold(string myString)
        {
            string lString = "\\b " + myString + "\\b0 ";
            return lString;
        }

        public static string FormatWithItalics(string myString)
        {
            string lString = "\\i " + myString + "\\i0 ";
            return lString;
        }

        public static string ReturnRTFReturn()
        {
            return "\\par\\n ";
        }
	}
}
