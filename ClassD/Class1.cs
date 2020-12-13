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
}
