using System;

namespace zerotooneproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program turns zero and one into 1 and 0 and if you type anything other than that it will skip.");
            //user input 
            Console.WriteLine("Please enter in either 'one' or zero' separtated by a space.");
            string words = Console.ReadLine();
            //the function is being called here
            Binary(words);

        }
        //static array for both one and zero
        static string[] Binary(string toNumber)
        {  
            string[] toBinary = toNumber.Split(' ');
            foreach (var word in toBinary) 
            {  //if statements to make sure that user will type one and zero 
              // and an else to make sure if the user types anything that is not one or zero it will skip over it
                if(word == "zero")
                {
                    Console.Write("0");
                }
                if (word == "one")
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("");
                }
             
            }//return type to make sure that operation was performed well 
            return toBinary;
        }//end
    }
}
   