using System;


namespace CheckingArrays
{
	class NullCheck
	{
		static void Main(string[] args)
		{
			double[] balance = new double[3];
			balance[0] = 2.0;
			balance[1] = 4.0;
			balance[2] = 5.0;
			double[] balance_copy = balance;
			balance_copy[2] = 14.0;
			Console.WriteLine("{0}, {1}", balance[2], balance_copy[2]); 
		}
	}
}