/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 13/12/2019
 * Heure: 08:01
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace SPID2Deconnecte
{
	/// <summary>
	/// Description of SingletonOutils.
	/// </summary>
	public sealed class SingletonOutils
	{
		static SingletonOutils instance = null;
		static readonly object padlock = new object();

		public static string REP_DB = Path.DirectorySeparatorChar + "Database";
		public static string REP_IMPORT = REP_DB + Path.DirectorySeparatorChar + "Import_Export";

		public static string DB_FILE = "SPID2D";
		public static string DB_EXTENSION = ".db";
		public static string DB_NAME = DB_FILE + DB_EXTENSION;

		public static string CONNECTION_STRING = Directory.GetCurrentDirectory() + REP_DB + Path.DirectorySeparatorChar + DB_NAME;

		public static string TEXT_SEPARATOR = new String('-', 60) + Environment.NewLine;

		// Nom du fichier INI
		public const string FILEINI = "config.ini";


		public static SingletonOutils GetInstance()
		{
			if (instance == null)
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new SingletonOutils();
					}
				}
			}
			return instance;
		}

		private SingletonOutils() { }

		public static string CharParse(string str)
		{
			string car = str.Substring(0,1);

			if (str.CompareTo(" ") == 0)
				return null;

			return car;
		}

		public static ushort? ShortParse(string str)
		{
			string str2 = str.Trim();

			if (str2.Length == 0)
				return (ushort?) null;

            return ushort.Parse(str2);
		}

		public static long? LongParse(string str)
        {
			string str2 = str.Trim();

			if (str2.Length == 0)
				return null;

			return Convert.ToInt64(str2);
        }

		public static long? LongSParse(string str)
		{
			string str2 = str.Trim();

			if (str2.Length == 0)
				return null;

			return Convert.ToInt64(str2);
		}

		public static string StringParse(string str)
		{ 
			str = str.Trim();
			if (str.Length == 0)
				return "";

			return str;
		}

		public static DateTime DateParse(string str)
		{

			str = str.Trim();
			if (str.Length == 0)
				return new DateTime(1900,1,1); // 01/01/0001 12h00

			return DateTime.ParseExact(str, "dd/MM/yyyy", CultureInfo.InvariantCulture);
		}

		public static void SetTextRapport(RichTextBox txtRapport, string sText, bool bold = false)
		{
			System.Drawing.Font currentFont = txtRapport.SelectionFont;

			if (bold)
			{
				txtRapport.AppendText(Environment.NewLine);
				txtRapport.SelectionFont = new Font(
					currentFont.FontFamily,
					14,
					FontStyle.Bold
				);
			}

			txtRapport.AppendText(sText + Environment.NewLine);

			if (bold)
				txtRapport.SelectionFont = new Font(
					currentFont.FontFamily,
					11,
					FontStyle.Regular
				);
		}

		public static void SetTextRapport(RichTextBox txtRapport, string sText, Color color, bool AddNewLine = false)
		{
			if (AddNewLine)
				sText += Environment.NewLine;

			txtRapport.SelectionStart = txtRapport.TextLength;
			txtRapport.SelectionLength = 0;

			txtRapport.SelectionColor = color;
			txtRapport.AppendText(sText);
			txtRapport.SelectionColor = txtRapport.ForeColor;
		}

		public static void TRUNCATE(string sTableName)
		{
			using (var db = new PetaPoco.Database("SqliteConnect"))
			{
				db.Execute("DELETE FROM @0;", sTableName);
				db.Execute("DELETE FROM sqlite_sequence WHERE name = @0", sTableName);
			}
		}

	}
}