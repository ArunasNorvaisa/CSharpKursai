using System;

namespace CSharpKursai
{
	public class Pamoka3
	{

// test if number is primal

		bool testPrimal(int nr)
		{
			for(int i = 2; i < Math.Sqrt(nr); i++)
			{
				if (nr % i == 0) return false;
			}
			return true;
		}
	}
}
