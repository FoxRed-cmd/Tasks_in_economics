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
			radioButton2.CheckedChanged += (a, e) =>
			{
				if (radioButton2.Checked)
				{
					textBox1.Text = "31 декабря 2014 года Арсений взял в банке 1 млн. рублей в кредит. Схема выплаты кредита следующая: " +
					"31 декабря каждого следующего года банк начисляет проценты на оставшуюся сумму долга" +
					"(то есть увеличивает долг на определённое количество процентов), затем Арсений переводит очередной транш." +
					"Арсентий выплатил кредит за два транша, переводя в первый раз 550 тыс.рублей, во второй – 638,4 тыс.рублей.Под какой процент банк выдал кредит Арсению ? ";

					label1.Text = "Первый перевод";
					label2.Text = "Второй перевод";

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
			radioButton3.CheckedChanged += (a, e) =>
			{
				if (radioButton3.Checked)
				{
					textBox1.Text = "15 января планируется взять кредит в банке на 9 месяцев. Условия его возврата таковы:" +
					"- 1 - го числа каждого месяца долг возрастает на 3 % по сравнению с концом предыдущего месяца;" +
					"-со 2 - го по 14 - е число каждого месяца необходимо выплатить часть долга;" +
					"-15 - го числа каждого месяца долг должен быть на одну и ту же величину меньше долга на 15 - е число предыдущего месяца." +
					"Известно, что на пятый месяц кредитования нужно выплатить 57,5 тыс.рублей.Какую сумму нужно вернуть банку в течение всего срока кредитования?";

					label1.Text = "Сумма";
					label2.Text = "Процент";

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
			if (radioButton2.Checked)
			{
				Task2_Ec task2_Ec = new Task2_Ec()
				{
					First_transaction = Convert.ToDouble(textBox2.Text),
					Second_transaction = Convert.ToDouble(textBox3.Text)
				};
				textBox1.Text = "Ответ: " + task2_Ec.Decision() + " процентов";
			}
			if (radioButton3.Checked)
			{
				Task3_Ec task3_Ec = new Task3_Ec()
				{
					Sum = Convert.ToDouble(textBox2.Text),
					Percent = Convert.ToDouble(textBox3.Text)
				};
				textBox1.Text = textBox1.Text = "Ответ: " + task3_Ec.Decision() + " тыс. рублей";
			}
		}
	}
}
