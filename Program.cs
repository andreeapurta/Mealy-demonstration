using System;

namespace AutomatMealy
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Function f = new FC();
            Function g = new GC();
            AutomatMealy automatMealy = new AutomatMealy(f, g);
            //stare precedenta, caracter intrare, stare urmatoare, functia g
            try
            {
                Console.WriteLine(automatMealy.Evolutie("1", "aaabbabbc"));
            }
            catch (InvalidProgramException ex)
            {
                Console.WriteLine(ex.GetType().FullName + " - " + ex.Message);
            }
        }
    }
}