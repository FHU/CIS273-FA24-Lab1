using System;
namespace Polynomial
{

	// 4x^3 + 9x - 5
	public class Polynomial
	{
		LinkedList<Term> terms;

		public int NumberOfTerms => 0

		// TODO
		public int Degree
		{
			get
			{
				return 0;
			}

		}
		public Polynomial()
		{
			terms = new LinkedList<Term>();
		}

		// TODO
		public void AddTerm(double coeff, int power)
		{
			
		}

        public override string ToString()
        {
			string result = "";

			

			return result;
        }


        // TODO
        public static Polynomial Add(Polynomial p1, Polynomial p2)
		{
			// add add the terms from each polynomial to a new poly

			var sum = new Polynomial();

			

			return sum;
		}

		// TODO
		public static Polynomial Subtract(Polynomial p1, Polynomial p2)
		{
			return null;
		}

		// TODO
		public static Polynomial Negate(Polynomial p)
		{
            return null;
        }

		// TODO
		public static Polynomial Multiply(Polynomial p1, Polynomial p2)
		{
			return null;
		}



    }
}

