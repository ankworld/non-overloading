using System;

class MainClass
{
	static int addInt2 (int a, int b)
	{
		return a + b;	
	}

	static float addFloat2 (float a, float b)
	{
		return a + b;
	}

	static int subInt2 (int a, int b)
	{
		return a - b;
	}

	static float subFloat2 (float a, float b)
	{
		return a - b;
	}

	static int addInt3 (int a, int b, int c)
	{
		return a + b + c;	
	}

	static float addFloat3 (float a, float b, float c)
	{
		return a + b + c;
	}

	static int subInt3 (int a, int b, int c)
	{
		return a - b - c;
	}

	static float subFloat3 (float a, float b, float c)
	{
		return a - b - c;
	}

	static void Main (string[] args)
	{
		// Ask abount exemple or test by yourself
		Console.Write ("Exemple (Y,n) : ");
		string choice = Console.ReadLine ();
		if (choice.Length == 0) {
			choice = "Y";
		}

		// Print exemple
		if ((choice [0].Equals ('Y')) || (choice [0].Equals ('y'))) {
			int n1 = 5, n2 = 10, n3 = 15;
			Console.WriteLine ("-------------------------------------------\n");
			Console.WriteLine ("addInt2 : {0} + {1} = {2}"
					, n1, n2, addInt2 (n1, n2));
			Console.WriteLine ("addFloat2 : {0} + {1} = {2}"
					, n1 + 0.2f, n2 + 0.5f, addFloat2 (n1 + 0.2f, n2 + 0.5f));
			Console.WriteLine ("subInt2 : {0} - {1} = {2}"
					, n1, n2, subInt2 (n1, n2));
			Console.WriteLine ("subFloat2 : {0} - {1} = {2}"
					, n1 + 0.2f, n2 + 0.5f, subFloat2 (n1 + 0.2f, n2 + 0.5f));
			Console.WriteLine ("addInt3 : {0} + {1} + {2} = {3}"
					, n1, n2, n3, addInt3 (n1, n2, n3));
			Console.WriteLine ("addFloat3 : {0} + {1} + {2} = {3}"
					, n1 + 0.2f, n2 + 0.5f, n3 + 0.4f, addFloat3 (n1 + 0.2f, n2 + 0.5f, n3 + 0.4f));
			Console.WriteLine ("subInt3 : {0} - {1} - {2} = {3}"
					, n1, n2, n3, subInt3 (n1, n2, n3));
			Console.WriteLine ("subFloat3 : {0} - {1} - {2} = {3}"
					, n1 + 0.2f, n2 + 0.5f, n3 + 0.4f, subFloat3 (n1 + 0.2f, n2 + 0.5f, n3 + 0.4f));
			Console.WriteLine ("\n-------------------------------------------");
		} else {

			// Test by yourself
			// Get input and split to String Array
			Console.Write ("Input (1 2 3) : ");
			string[] opr = Console.ReadLine ().Trim ().Split (' ');
			// Get operator
			Console.Write ("Operator (+,-) : ");
			string opt = Console.ReadLine ();

			// Use opt at first index to be operator
			switch (opt [0]) {
			case '+':
				// Case '+' 2 operand
				if (opr.Length < 3) {
					// Case of float --> contain . character
					if ((opr [0].Contains (".")) || (opr [1].Contains (".")))
						Console.WriteLine ("{0} + {1} = {2}"
						, float.Parse (opr [0]), float.Parse (opr [1])
						, addFloat2 (float.Parse (opr [0]), float.Parse (opr [1])));
					else
					// Case of int
						Console.WriteLine ("{0} + {1} = {2}"
						, int.Parse (opr [0]), int.Parse (opr [1])
						, addInt2 (int.Parse (opr [0]), int.Parse (opr [1])));
				} else {
					// Case '+' 3 operand or more (but do only 1st -> 3rd operand)
					if ((opr [0].Contains (".")) || (opr [1].Contains (".") || (opr [2].Contains ("."))))
						Console.WriteLine ("{0} + {1} + {2} = {3}"
							, float.Parse (opr [0]), float.Parse (opr [1]), float.Parse (opr [2])
							, addFloat3 (float.Parse (opr [0]), float.Parse (opr [1]), float.Parse (opr [2])));
					else
						Console.WriteLine ("{0} + {1} + {2} = {3}"
							, int.Parse (opr [0]), int.Parse (opr [1]), int.Parse (opr [2])
							, addInt3 (int.Parse (opr [0]), int.Parse (opr [1]), int.Parse (opr [2])));
				}
				break;
			case '-':
				// like above but - instead +
				if (opr.Length < 3) {
					if ((opr [0].Contains (".")) || (opr [1].Contains (".")))
						Console.WriteLine ("{0} - {1} = {2}"
							, float.Parse (opr [0]), float.Parse (opr [1])
							, subFloat2 (float.Parse (opr [0]), float.Parse (opr [1])));
					else
						Console.WriteLine ("{0} - {1} = {2}"
							, int.Parse (opr [0]), int.Parse (opr [1])
							, subInt2 (int.Parse (opr [0]), int.Parse (opr [1])));
				} else {
					if ((opr [0].Contains (".")) || (opr [1].Contains (".") || (opr [2].Contains ("."))))
						Console.WriteLine ("{0} - {1} - {2} = {3}"
							, float.Parse (opr [0]), float.Parse (opr [1]), float.Parse (opr [2])
							, subFloat3 (float.Parse (opr [0]), float.Parse (opr [1]), float.Parse (opr [2])));
					else
						Console.WriteLine ("{0} - {1} - {2} = {3}"
							, int.Parse (opr [0]), int.Parse (opr [1]), int.Parse (opr [2])
							, subInt3 (int.Parse (opr [0]), int.Parse (opr [1]), int.Parse (opr [2])));
				}
				break;
			default:
				Console.WriteLine ("Sorry I can't do this now.");
				break;
			}

		}
	}
}

