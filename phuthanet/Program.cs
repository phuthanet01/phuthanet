using System;
namespace phuthanet01
{

    public class Program
    {

        public static void Main(string[] args)
        {
            for (int iterator = 0; iterator < 3; iterator++)
            {
                Console.WriteLine("Outer Loop:" + iterator);
                for (int _iterator = 0; _iterator < 2; _iterator++)
                {
                    Console.WriteLine("inner Loop:" + iterator);


                }
            }
            string[] brandTV = { "LG", "SONY", "SAMSUNG", "TCL", "JVC" };

            foreach (string television in brandTV)

                Console.WriteLine("Brand" + television);


        }
    }
}

