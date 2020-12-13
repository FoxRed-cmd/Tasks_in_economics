using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassD;

namespace Tasks_in_economics
{
	public partial class Form1 : Form
	{
		

		public Form1()
		{
			InitializeComponent();

			Label[] labels = new Label[] { label1, label2 };
			TextBox[] textBoxes = new TextBox[] { textBox2, textBox3 };

			radioButton1.CheckedChanged += (a, e) =>
			{
				if (radioButton1.Checked)
				{
					textBox1.Text = "31 декабря 2014 года Сергей взял в банке некоторую сумму в кредит под 12% годовых. Схема выплаты кредита следующая: " +
					"31 декабря каждого следующего года банк начисляет проценты на оставшуюся сумму долга ( то есть увеличивает долг на 12%), " +
					"затем Сергей переводит в банк 3512320 рублей. " +
					"Какую сумму взял Сергей в банке, если он выплатил долг тремя равными платежами ( то есть за три года)?";

					label1.Text = "Сумма";
					label2.Text = "Проценты банка";

					foreach (Label item in labels)
					{
						item.Visible = true;
					}
					foreach (TextBox item in textBoxes)
					{
						item.Visible = true;
					}
				}
				else
				{
					foreach (Label item in labels)
					{
						item.Visible = false;
					}
					foreach (TextBox item in textBoxes)
					{
						item.Visible = false;
					}
				}
			};
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				Task1_Ec task1_Ec = new Task1_Ec()
				{
					Sum = Convert.ToDouble(textBox2.Text),
					Percent = Convert.ToDouble(textBox3.Text)
				};
				textBox1.Text = "Ответ: " + task1_Ec.Decision() + " рублей";
			}
		}
	}
}
