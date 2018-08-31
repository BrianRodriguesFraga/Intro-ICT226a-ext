using System;

namespace tests
{
    public class Calculator
    {
        #region variables
        private char ope;
        private double op1;
        private double op2;
        private double resultat;
        #endregion variables

        void Main(string[] args)
        {

            Console.Write("Entrée le premier nombre : \n");
            op1 = int.Parse(Console.ReadLine());

            Console.Write("\n\nEntrée l'opérateur : \n");
            ope = (char)Console.Read();

            Console.Write("\n\nEntrée le second nombre : \n");
            op2 = int.Parse(Console.ReadLine());

            resultat = op1 + ope + op2;

            Console.Write("\n\nLe résultat est : " + resultat);

            Console.ReadLine();
        }

        public int addi(int re1, int re2)
        {
            return re1 + re2;
        }

        private int sous(int re1, int re2)
        {
            return re1 - re2;
        }

        private int mult(int re1, int re2)
        {
            return re1 * re2;
        }

        private double divi(int re1, int re2)
        {

            return re1 / re2;
        }

    }
}
