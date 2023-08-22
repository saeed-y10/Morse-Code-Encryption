using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeEncryption
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private bool IsMorseCode(char Code)
		{
			return (Code == '.' || Code == '-');
		}

		private bool IsMorseCode(string Code)
		{
			foreach (char c in Code)
			{
				if (c != '-' && c != '.')
					return false;
			}

			return true;
		}

        private string ToMorseCode(char Letter)
		{
			Letter = Char.ToLower(Letter);

			switch (Letter)
			{

				case 'a':
					return ".-";

				case 'b':
					return "-...";

				case 'c':
					return "-.-.";

				case 'd':
					return "-..";

				case 'e':
					return ".";

				case 'f':
					return "..-.";

				case 'g':
					return "--.";

				case 'h':
					return "....";

				case 'i':
					return "..";

				case 'j':
					return ".---";

				case 'k':
					return "-.-";

				case 'l':
					return ".-..";

				case 'm':
					return "--";

				case 'n':
					return "-.";

				case 'o':
					return "---";

				case 'p':
					return ".--.";

				case 'q':
					return "--.-";

				case 'r':
					return ".-.";

				case 's':
					return "...";

				case 't':
					return "-";

				case 'u':
					return "..-";

				case 'v':
					return "...-";

				case 'w':
					return ".--";

				case 'x':
					return "-..-";

				case 'y':
					return "-.--";

				case 'z':
					return "--..";

				case '0':
					return "-----";

				case '1':
					return "----";

				case '2':
					return "..---";

				case '3':
					return "...--";

				case '4':
					return "....-";

				case '5':
					return ".....";

				case '6':
					return "-....";

				case '7':
					return "--...";

				case '8':
					return "---..";

				case '9':
					return "----.";

				case ' ':
					return ".......";

				case '.':
					return ".-.-.-";

				case ',':
					return "--..--";

				case '\'':
					return ".----.";

				case '\"':
					return ".-..-.";

				case ':':
					return "---...";

				case '?':
					return "..--..";

				case '-':
					return "-....-";

				case '+':
					return ".-.-.";

				case '/':
					return "-..-.";

				case '=':
					return "-...-";

				case '@':
					return ".--.-.";

				case ')':
					return "-.--.-";

				case '(':
					return "-.--.";
			}

			return "";
		}

        private char ToAlphabet(string Morse)
		{
			if (Morse == ".......")
				return ' ';

			else if (Morse == ".-")
				return 'a';

			else if (Morse == "-...")
				return 'b';

			else if (Morse == "-.-.")
				return 'c';

			else if (Morse == "-..")
				return 'd';

			else if (Morse == ".")
				return 'e';

			else if (Morse == "..-.")
				return 'f';

			else if (Morse == "--.")
				return 'g';

			else if (Morse == "....")
				return 'h';

			else if (Morse == "..")
				return 'i';

			else if (Morse == ".---")
				return 'j';

			else if (Morse == "-.-")
				return 'k';

			else if (Morse == ".-..")
				return 'l';

			else if (Morse == "--")
				return 'm';

			else if (Morse == "-.")
				return 'n';

			else if (Morse == "---")
				return 'o';

			else if (Morse == ".--.")
				return 'p';

			else if (Morse == "--.-")
				return 'q';

			else if (Morse == ".-.")
				return 'r';

			else if (Morse == "...")
				return 's';

			else if (Morse == "-")
				return 't';

			else if (Morse == "..-")
				return 'u';

			else if (Morse == "...-")
				return 'v';

			else if (Morse == ".--")
				return 'w';

			else if (Morse == "-..-")
				return 'x';

			else if (Morse == "-.--")
				return 'y';

			else if (Morse == "--..")
				return 'z';

			else if (Morse == "-----")
				return '0';

			else if (Morse == "----")
				return '1';

			else if (Morse == "..---")
				return '2';

			else if (Morse == "...--")
				return '3';

			else if (Morse == "....-")
				return '4';

			else if (Morse == ".....")
				return '5';

			else if (Morse == "-....")
				return '6';

			else if (Morse == "--...")
				return '7';

			else if (Morse == "---..")
				return '8';

			else if (Morse == "----.")
				return '9';

			else if (Morse == ".-.-.-")
				return '.';

			else if (Morse == "--..--")
				return ',';

			else if (Morse == ".----.")
				return '\'';

			else if (Morse == ".-..-.")
				return '\"';

			else if (Morse == "---...")
				return ':';

			else if (Morse == "..--..")
				return '?';

			else if (Morse == "-....-")
				return '-';

			else if (Morse == ".-.-.")
				return '+';

			else if (Morse == "-...-")
				return '=';

			else if (Morse == "-..-.")
				return '/';

			else if (Morse == ".--.-.")
				return '@';

			else if (Morse == "-.--.")
				return '(';

			else if (Morse == "-.--.-")
				return ')';

			else
				return '\0';
		}

		private bool IsValidCode(string Code)
		{
			string []vCode = Code.Split(' ');

			foreach (string C in vCode)
			{
				if (!IsMorseCode(C))
					return false;
			}

			return true;
		}

        private string Encryption(string Text)
		{
			string EncryptedText = "";

			for (int i = 0; i < Text.Length; i++)
			{
				EncryptedText += ToMorseCode(Text[i]) + " ";
			}

			return EncryptedText.Substring(0, EncryptedText.Length - 1);
		}

		private string Decryption(string Text)
		{
			if (!IsValidCode(Text))
				return "Invalid Input!";

			string []vText = Text.Split(' ');

			string DecryptedText = "";

			foreach (string Word in vText)
			{
				DecryptedText += ToAlphabet(Word);
			}

			return DecryptedText;
		}

        private void btnRevert_Click(object sender, EventArgs e)
        {
			if (txbEnglish.ReadOnly)
			{
				txbEnglish.Text = "";
				txbEnglish.ReadOnly = false;

				txbMorseCode.Text = "";
				txbMorseCode.ReadOnly = true;

				txbEnglish.Focus();
			}

			else
			{
				txbMorseCode.Text = "";
				txbMorseCode.ReadOnly = false;

				txbEnglish.Text = "";
				txbEnglish.ReadOnly = true;

				txbMorseCode.Focus();
			}
		}

        private void btnConvert_Click(object sender, EventArgs e)
        {
			if (txbMorseCode.ReadOnly)
            {
				txbMorseCode.Text = Encryption(txbEnglish.Text.ToString());
			}

			else
            {
				txbEnglish.Text = Decryption(txbMorseCode.Text.ToString());
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
			txbEnglish.Text = "";
			txbMorseCode.Text = "";
		}

        private void txbEnglish_Enter(object sender, EventArgs e)
        {
			if (!txbEnglish.ReadOnly)
            {
				txbEnglish.Text = "";
				txbEnglish.ForeColor = Color.Black;
            }
        }

        private void txbEnglish_Leave(object sender, EventArgs e)
        {
			if (!txbEnglish.ReadOnly)
			{
				txbEnglish.Text = "Enter a Text";
				txbEnglish.ForeColor = Color.Gray;
			}
		}

		private void txbMorseCode_Enter(object sender, EventArgs e)
        {
			if (!txbMorseCode.ReadOnly)
			{
				txbMorseCode.Text = "";
				txbMorseCode.ForeColor = Color.Black;
			}
		}

        private void txbMorseCode_Leave(object sender, EventArgs e)
        {
			if (!txbMorseCode.ReadOnly)
			{
				txbMorseCode.Text = "Enter a Morse Code";
				txbMorseCode.ForeColor = Color.Gray;
			}
		}
    }
}
