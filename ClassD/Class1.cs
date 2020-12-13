using static System.Math;

namespace ClassD
{
	public class Task1_Ec
	{
		public double Sum { get; set; }
		public double Percent { get; set; }
		private double percent;

		public double Decision()
		{
			percent = 1 + Percent / 100;
			return (Sum * (Pow(percent, 2) + percent + 1)) / Pow(percent, 3);
		}
	}
	public class Task2_Ec
	{
		public double First_transaction { get; set; }
		public double Second_transaction { get; set; }
		private double D;

		public double Decision()
		{
			D = Pow(145, 2) - 4 * (1000 - First_transaction - Second_transaction) * 10;
			return (-145 + Sqrt(D)) / 2;
		}
	}
	public class Task3_Ec
	{
		public double Sum { get; set; }
		public double Percent { get; set; }
		private double temp;

		public double Decision()
		{
			temp = Sum * (9 / 1.15);
			return (10.35 / 9) * temp;
		}
	}
}
