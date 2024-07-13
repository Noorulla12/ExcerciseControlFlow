using System;
using System.Collections.Generic;
using System.Threading.Channels;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
              var names = new List<string>();
              while (true)
              {
                  Console.Write("Type your Name:");
                  var input = Console.ReadLine();
                  if (string.IsNullOrWhiteSpace(input))
                  {
                      break;
                  }
                  else
                  {
                      names.Add(input);
                  }

              }
              for (var i = 0; i < names.Count; i++)
              {
                  Console.WriteLine(names[i] + " liked your post!!");
              }    */


            // 2.
            

            Console.Write("Enter your Name: ");
            var originalString = Console.ReadLine();

            char[] StringArray = originalString.ToCharArray();

            Array.Reverse(StringArray);

            string ReversedString = new string(StringArray);

            Console.WriteLine("ReversedString : " + ReversedString);    
            

        }
    }
}