using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymbatDiplom
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();
			radioButton2.Checked = true;
			checkBox1.Checked = true;
			checkBox2.Checked = true;
		}

        private void Encoding()
        {

			TextBox[] textBoxes = groupBox1.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
			string[] massiv = new string[textBoxes.Length];
			for (int i = 0; i < textBoxes.Length; i++)
			{
				massiv[i] = textBoxes[i].Text;
			}

			TextBox[] textBoxesF = groupBox3.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
			string[] massivF = new string[textBoxesF.Length];
			for (int i = 0; i < textBoxesF.Length; i++)
			{
				massivF[i] = textBoxesF[i].Text;
			}

			int n;

			if (radioButton1.Checked)
			{
				n = 3;
				int a = 8;
				int[][] u =
				{
				new int[] {Int32.Parse(massiv[0]), Int32.Parse(massiv[1]), Int32.Parse(massiv[2])},
				new int[] {Int32.Parse(massiv[4]), Int32.Parse(massiv[5]), Int32.Parse(massiv[6])},
				new int[] {Int32.Parse(massiv[8]), Int32.Parse(massiv[9]), Int32.Parse(massiv[10])},
				new int[] {Int32.Parse(massiv[12]), Int32.Parse(massiv[13]), Int32.Parse(massiv[14])},
				new int[] {Int32.Parse(massiv[16]), Int32.Parse(massiv[17]), Int32.Parse(massiv[18])},
				new int[] {Int32.Parse(massiv[20]), Int32.Parse(massiv[21]), Int32.Parse(massiv[22])},
				new int[] {Int32.Parse(massiv[24]), Int32.Parse(massiv[25]), Int32.Parse(massiv[26])},
				new int[] {Int32.Parse(massiv[28]), Int32.Parse(massiv[29]), Int32.Parse(massiv[30])}
				};

				int[][] ux = RectangularArrays.RectangularIntArray(a, a);
				for (int i = 0; i < a; i++)
				{
					for (int j = 0; j < a; j++)
					{
						ux[i][j] = 0;
						for (int k = 0; k < n; k++)
						{
							ux[i][j] += u[i][k] * u[j][k];
						}
					}
				}

				for (int i = 0; i < a; i++)
				{
					for (int j = 0; j < a; j++)
					{

						richTextBox1.Text += ux[i][j] + " ";
					}

					richTextBox1.Text += "\n";
				}
				if (checkBox1.Checked) {
				int[] f = new int[a];
				TextBox[] textBoxesf = groupBox2.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
				string[] massivf = new string[textBoxesf.Length];
				string textBuff = "";
				for (int i = 0; i < textBoxesf.Length; i++)
				{
					massivf[i] = textBoxesf[i].Text;
					textBuff += massivf[i];
				}

				for (int i = 0; i < a; i++)
				{
					f[i] = Int32.Parse(massivf[i]);
				}
				int[] w = new int[a];
				for (int i = 0; i < a; i++)
				{
					w[i] = 0;
					for (int j = 0; j < a; j++)
					{
						w[i] += f[j] * Convert.ToInt32(Math.Pow(-1, ux[i][j]));
					}
					richTextBox2.Text += "w[" + (i + 1) + "]=" + w[i] + "\n";
				}




				
				for (int i = 0; i < a; i++)
				{
					textBoxesF[i].Text = w[i].ToString();
					massivF[i] = textBoxesF[i].Text;
				}
			}


				if (checkBox2.Checked)
				{
					double[] F = new double[a];
					for (int i = 0; i < a; i++)
					{
						F[i] = 0;
						for (int j = 0; j < a; j++)
						{
							F[i] += Math.Pow(1.0 / 2.0, n) * Convert.ToDouble(massivF[j]) * (double)Math.Pow(-1, ux[i][j]);
						}
						richTextBox3.Text += "f[" + (i + 1) + "]=" + F[i] + "\n";
					}
				}
			}

			if (radioButton2.Checked)
			{
				n = 4;
				int a = 16;
				int[][] u =
				{
				new int[] {Int32.Parse(massiv[0]), Int32.Parse(massiv[1]), Int32.Parse(massiv[2]), Int32.Parse(massiv[3])},
				new int[] {Int32.Parse(massiv[4]), Int32.Parse(massiv[5]), Int32.Parse(massiv[6]), Int32.Parse(massiv[7])},
				new int[] {Int32.Parse(massiv[8]), Int32.Parse(massiv[9]), Int32.Parse(massiv[10]), Int32.Parse(massiv[11])},
				new int[] {Int32.Parse(massiv[12]), Int32.Parse(massiv[13]), Int32.Parse(massiv[14]), Int32.Parse(massiv[15])},
				new int[] {Int32.Parse(massiv[16]), Int32.Parse(massiv[17]), Int32.Parse(massiv[18]), Int32.Parse(massiv[19])},
				new int[] {Int32.Parse(massiv[20]), Int32.Parse(massiv[21]), Int32.Parse(massiv[22]), Int32.Parse(massiv[23])},
				new int[] {Int32.Parse(massiv[24]), Int32.Parse(massiv[25]), Int32.Parse(massiv[26]), Int32.Parse(massiv[27])},
				new int[] {Int32.Parse(massiv[28]), Int32.Parse(massiv[29]), Int32.Parse(massiv[30]), Int32.Parse(massiv[31])},
				new int[] {Int32.Parse(massiv[32]), Int32.Parse(massiv[33]), Int32.Parse(massiv[34]), Int32.Parse(massiv[35])},
				new int[] {Int32.Parse(massiv[36]), Int32.Parse(massiv[37]), Int32.Parse(massiv[38]), Int32.Parse(massiv[39])},
				new int[] {Int32.Parse(massiv[40]), Int32.Parse(massiv[41]), Int32.Parse(massiv[42]), Int32.Parse(massiv[43])},
				new int[] {Int32.Parse(massiv[44]), Int32.Parse(massiv[45]), Int32.Parse(massiv[46]), Int32.Parse(massiv[47])},
				new int[] {Int32.Parse(massiv[48]), Int32.Parse(massiv[49]), Int32.Parse(massiv[50]), Int32.Parse(massiv[51])},
				new int[] {Int32.Parse(massiv[52]), Int32.Parse(massiv[53]), Int32.Parse(massiv[54]), Int32.Parse(massiv[55])},
				new int[] {Int32.Parse(massiv[56]), Int32.Parse(massiv[57]), Int32.Parse(massiv[58]), Int32.Parse(massiv[59])},
				new int[] {Int32.Parse(massiv[60]), Int32.Parse(massiv[61]), Int32.Parse(massiv[62]), Int32.Parse(massiv[63])}
				};

				int[][] ux = RectangularArrays.RectangularIntArray(a, a);
				for (int i = 0; i < a; i++)
				{
					for (int j = 0; j < a; j++)
					{
						ux[i][j] = 0;
						for (int k = 0; k < n; k++)
						{
							ux[i][j] += u[i][k] * u[j][k];
						}
					}
				}

				for (int i = 0; i < a; i++)
				{
					for (int j = 0; j < a; j++)
					{

						richTextBox1.Text += ux[i][j] + " ";
					}

					richTextBox1.Text += "\n";
				}
				if (checkBox1.Checked)
				{
					int[] f = new int[a];
					TextBox[] textBoxesf = groupBox2.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
					string[] massivf = new string[textBoxesf.Length];
					string textBuff = "";
					for (int i = 0; i < textBoxesf.Length; i++)
					{
						massivf[i] = textBoxesf[i].Text;
						textBuff += massivf[i];
					}

					for (int i = 0; i < a; i++)
					{
						f[i] = Int32.Parse(massivf[i]);
					}
					int[] w = new int[a];
					for (int i = 0; i < a; i++)
					{
						w[i] = 0;
						for (int j = 0; j < a; j++)
						{
							w[i] += f[j] * Convert.ToInt32(Math.Pow(-1, ux[i][j]));
						}
						richTextBox2.Text += "w[" + (i + 1) + "]=" + w[i] + "\n";
					}





					for (int i = 0; i < a; i++)
					{
						textBoxesF[i].Text = w[i].ToString();
						massivF[i] = textBoxesF[i].Text;
					}
				}


				if (checkBox2.Checked)
				{
					double[] F = new double[a];
					for (int i = 0; i < a; i++)
					{
						F[i] = 0;
						for (int j = 0; j < a; j++)
						{
							F[i] += Math.Pow(1.0 / 2.0, n) * Convert.ToDouble(massivF[j]) * (double)Math.Pow(-1, ux[i][j]);
						}
						richTextBox3.Text += "f[" + (i + 1) + "]=" + F[i] + "\n";
					}
				}
			}

		}

        internal static class RectangularArrays
        {
            public static int[][] RectangularIntArray(int size1, int size2)
            {
                int[][] newArray = new int[size1][];
                for (int array1 = 0; array1 < size1; array1++)
                {
                    newArray[array1] = new int[size2];
                }

                return newArray;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

			TextBox[] textBoxesF = groupBox3.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
			string[] massivF = new string[textBoxesF.Length];
			for (int i = 0; i < textBoxesF.Length; i++)
			{
				if (i > 7)
				{
					textBoxesF[i].Enabled = false;
				}
			}


			TextBox[] textBoxesf = groupBox2.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
			string[] massivf = new string[textBoxesf.Length];
			for (int i = 0; i < textBoxesf.Length; i++)
			{
				if (i > 7)
				{
					textBoxesf[i].Enabled = false;
				}
			}

			TextBox[] textBoxes = groupBox1.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
            string[] massiv = new string[textBoxes.Length];
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if ((i+1) % 4 == 0 || i > 31)
                {
                    textBoxes[i].Enabled = false;
                }
            }
			textBoxes[6].Text = "0";
			textBoxes[9].Text = "0";
			textBoxes[10].Text = "1";
			textBoxes[12].Text = "0";
			textBoxes[13].Text = "1";
			textBoxes[16].Text = "1";
			textBoxes[17].Text = "0";
			textBoxes[18].Text = "0";
			textBoxes[20].Text = "0";
			textBoxes[24].Text = "0";
			textBoxes[26].Text = "1";
			textBoxes[28].Text = "0";
			textBoxes[30].Text = "0";
		}

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
			TextBox[] textBoxesF = groupBox3.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
			string[] massivF = new string[textBoxesF.Length];
			for (int i = 0; i < textBoxesF.Length; i++)
			{
				if (i > 7)
				{
					textBoxesF[i].Enabled = true;
				}
			}


			TextBox[] textBoxesf = groupBox2.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
			string[] massivf = new string[textBoxesf.Length];
			for (int i = 0; i < textBoxesf.Length; i++)
			{
				if (i > 7)
				{
					textBoxesf[i].Enabled = true;
				}
			}

			TextBox[] textBoxes = groupBox1.Controls.OfType<TextBox>().OrderBy(i => i.Name).ToArray();
            string[] massiv = new string[textBoxes.Length];
            for (int i = 0; i < textBoxes.Length; i++)
            {
                massiv[i] = textBoxes[i].Text;
                if ((i + 1) % 4 == 0 || i > 31)
                {
                    textBoxes[i].Enabled = true;
                }
			}
			textBoxes[6].Text = "1";
			textBoxes[9].Text = "1";
			textBoxes[10].Text = "0";
			textBoxes[12].Text = "1";
			textBoxes[13].Text = "0";
			textBoxes[16].Text = "0";
			textBoxes[17].Text = "1";
			textBoxes[18].Text = "1";
			textBoxes[20].Text = "1";
			textBoxes[24].Text = "1";
			textBoxes[26].Text = "0";
			textBoxes[28].Text = "1";
			textBoxes[30].Text = "1";
		}

        private void button1_Click(object sender, EventArgs e)
        {
			richTextBox1.Clear();
			richTextBox2.Clear();
			richTextBox3.Clear();
			Encoding();
        }

        
    }
}
