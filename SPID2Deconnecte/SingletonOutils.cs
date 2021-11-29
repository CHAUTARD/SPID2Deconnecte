﻿/*
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

		public static string CONNECTION_STRING = Directory.GetCurrentDirectory() + REP_DB + Path.DirectorySeparatorChar + "SPID2D.sqlite";

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

		public static char? CharParse(string str)
		{
			char car = str[0];

			if (car == ' ')
				return null;

			return car;
		}

		public static ushort? ShortParse(string str)
		{
			string str2 = str.Trim();

			if (str2.Length == 0)
				return null;

            return ushort.Parse(str2);
		}

		public static ulong? LongParse(string str)
        {
			string str2 = str.Trim();

			if (str2.Length == 0)
				return null;

			return Convert.ToUInt64(str2);
        }

		public static string StringParse(string str)
		{ 
			str = str.Trim();
			if (str.Length == 0)
				return null;

			return str;
		}

		public static void setTextRapport(RichTextBox txtRapport, string sText, bool bold = false)
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

		public static void setTextRapport(RichTextBox txtRapport, string sText, Color color, bool AddNewLine = false)
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