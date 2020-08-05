using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  
    namespace ClassAssignmentTwoStrings
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter first string");
                string str1 = Console.ReadLine();
                Console.WriteLine("Enter second string");
                string str2 = Console.ReadLine();
                Console.WriteLine("String Menu");
                Console.WriteLine("1.Concatenate String\n", "2.Length of 2 String\n", "3.SubString\n", "4.Replace\n", "5.Uppercase\n", "6.Lowercase\n", "7.Trim\n", "8.Split\n");

                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine(str1 + str2);
                        break;
                    case 2:
                        int sum = str1.Length + str2.Length;
                        Console.WriteLine(sum);
                        break;
                    case 3:
                        
                        int obj = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(str1.Substring(obj));
                        Console.WriteLine(  str2.Substring(obj));
                        break;
                    case 4:
                        var concat = str1 + " " + str2;
                        Console.WriteLine("Original " + concat);
                        Console.WriteLine("Enter a word you want to replace: ");
                        string obj2 = Console.ReadLine();
                        Console.WriteLine("With: ");
                        string obj3 = Console.ReadLine();
                        Console.WriteLine("After Replace" + str1.Replace(obj2, obj3) + " " + str2.Replace(obj2, obj3));
                        break;
                    case 5:
                        Console.WriteLine( str1.ToUpper());
                        Console.WriteLine(str2.ToUpper());
                        break;
                    case 6:
                        Console.WriteLine("Strig 1: " + str1.ToLower());
                        Console.WriteLine("Strig 2: " + str2.ToLower());
                        break;
                    case 7:
                        Console.WriteLine(  str1.Trim());
                        Console.WriteLine(  str2.Trim());
                        break;
                    case 8:
                        var concat1 = str1 + " " + str2;
                        Console.WriteLine("Original" + concat1);
                        char[] spearator = { ' ', ' ' };
                        int count = 4;
                        string[] strlist = concat1.Split(spearator,count, StringSplitOptions.None);
                        Console.WriteLine("After split from space");
                        foreach (String str in strlist)
                        {
                            Console.WriteLine(str);
                        }
                        break;

                    default:
                        Console.WriteLine("PLease check the number you have entered");
                        break;
                }
                Console.Read();



            }
        }
    }


    