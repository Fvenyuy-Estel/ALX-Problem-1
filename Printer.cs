
using System;

class Printer {
	static int maxPrint(int N)
	{
		if (N <= 6)
			return N;
		int max = 0;

		int b;
		for (b = N - 3; b >= 1; b--) {
			int curr = (N - b - 1) * maxPrint(b);
			if (curr > max)
				max = curr;
		}
		return max;
	}

	static void Main()
	{
		Console.WriteLine("Enter a number to get the max number of A's that can be printed: ");
		int N = int.Parse(Console.ReadLine());
		Console.WriteLine("Maximum Number of A's with " + N + " keystrokes is " + maxPrint(N));
	}
}

