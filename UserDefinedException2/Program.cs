using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException2
{
    class Calculate
    {
         int num1 =10 ;
         int num2 =0 ;

        public int sum { get; internal set; }

        public void FindAverage(params int[] values)
        {

            if (num2 == 0 || num2 >1000)
            {
                throw (new CountIsZeroException("Second Number Should not be zero or greater than 1000 , Try again!!!"));
            }
            else
            {
                
               int sum = num1 + num2;

            }

        }

        internal void Findsum()
        {
            throw new NotImplementedException();
        }
    }

    public class CountIsZeroException : ApplicationException
    {
        public CountIsZeroException(string message) : base(message)
        {

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("Handling User Defined Exception ");
            Calculate calc = new Calculate();

            try
            {
                calc.Findsum();
            }
            catch (CountIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The Sum is {0}  ", calc.sum);
            }
            Console.ReadKey();
        }
    }
}


