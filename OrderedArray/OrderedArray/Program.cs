using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EvaluateString();
            Console.ReadLine();
        }

        static void EvaluateString()
        {
            Console.WriteLine("Please enter your word. Ensure there is a Capital Letter in it");
            var text = Console.ReadLine();
            var result = text.Select((value, index)=> new UpperCaseItem(value, index, char.IsUpper(value))).Where(x => x.IsUpper);



            foreach (var item in result)
            {
              
                Console.Write($"{item.Index,-5:D}");
                
                

            }

            Console.ReadLine();
        }


       
    }

    public class UpperCaseItem
    {
        //use properties for getting variables
        public char Value { get; }
        public int Index { get; }
        public bool IsUpper { get; }

        //using method 
        public UpperCaseItem(char value, int index, bool isUpper)
        {
            Value = value;
            Index = index;
            IsUpper = isUpper;
        }
    }


       

}
