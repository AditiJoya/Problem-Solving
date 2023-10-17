// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using examprac;

Console.WriteLine("Hello, World!");
//int[] arraylist=new int[] {10,50,30,42,15,7,9};
//int max = arraylist[0];
//int min = arraylist[0];
//for(int i=0;i<arraylist.Length;i++)
//{
//    if (max < arraylist[i])
//        max= arraylist[i];

//}
//for(int i=0;i<arraylist.Length;i++)
//{
//    if (min > arraylist[i])
//        min= arraylist[i];
//}
//Console.WriteLine(max);
//Console.WriteLine(min);



//int oddcounter = 0;
//int evencounter = 0;
//for (int i = 0; i < arraylist.Length; i++)
//{
//    if (arraylist[i] % 2 == 0)
//    {
//        evencounter++;
//    }
//    else
//        oddcounter++;
//}
//Console.WriteLine(evencounter);
//Console.WriteLine(oddcounter);



//double num1 = Convert.ToDouble(Console.ReadLine());
//double num2 = Convert.ToDouble(Console.ReadLine());
//char oparetor=Convert.ToChar(Console.Read());
//switch (oparetor)
//{

//    case '+':
//        { 
//        Console.WriteLine("Addition Of {0} and {1} is {2}", num1, num2, num1 + num2);
//        break;
//     }

//    case '-':
//        {
//            Console.WriteLine("Substraction Of {0} and {1} is {2}", num1, num2, num1 - num2);
//            break;
//        }

//    case '*':
//        {
//            Console.WriteLine("Multiplication Of {0} and {1} is {2}", num1, num2, num1 * num2);
//            break;
//        }

//    case '/':
//        {
//            Console.WriteLine("Division Of {0} and {1} is {2}", num1, num2, num1 / num2);
//            break;
//        }
//        default:
//        {
//            Console.WriteLine("envalid input");
//            break;
//        }

//}



//C# Program to Test Admission Eligibility over Following Conditions:
//▪ Marks in Physics and Mathematics must be greater than or equal to 65.
//▪ Marks in Chemistry must be greater than or equals to 50.
//▪ Combined marks of Physics and Mathematics must be greater than or equal to 130.
//▪ Total marks of Physics, Mathematics and Chemistry must be greater than or equal to 180.
//▪ If a single condition from above is not satisfied then the candidate is not eligible for admission.


//int physics = 70;
//int mathematics = 70;
//int chemistry = 60;
//if(physics>=65)
//{
//    if(mathematics>=65)
//    {
//        if(chemistry>=50)
//        {
//            if((physics + mathematics>=130) || (physics + mathematics + chemistry >= 180))
//            {
//                Console.WriteLine("eligable");
//            }

//        }
//        else
//        {
//            Console.WriteLine("Not eligable");
//        }

//    }
//    else
//    {
//        Console.WriteLine("Not eligable");
//    }
//}
//else
//{
//    Console.WriteLine("Not eligable");
//}

//C# Program to Filter Numbers from 1 to 10 from an Array Using LINQ
//int[] arraylist = new int[] { 1,2,4,7,10,12,14,15 };
//var querys = from alist in arraylist
//             where alist >= 1 && alist <= 10
//             select alist;
//foreach (var x in querys) 
//Console.WriteLine(x);



//C# Program to Solve Following Problems Using Class and Object-Oriented Style:
//▪ Determine if a number is Even or Odd.
//▪ Determine if a number is Zero or Negative or Positive.
//▪ Determine if a number is Prime or Not.
//▪ Determine if a number is Greater than or Less than the other.
//▪ Determine if an Alphabet is Uppercase or Lowercase.

//javaclassproject


Cheaker cheakers= new Cheaker();
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input is {0}",cheakers.oddeven(num));

int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input is {0}", cheakers.zeronegpositive(num1));

int fst = Convert.ToInt32(Console.ReadLine());
int snd = Convert.ToInt32(Console.ReadLine());
int thrd = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input is {0}", cheakers.greaters(fst,snd,thrd));

char chars = Convert.ToChar(Console.Read());
Console.WriteLine("input is {0}", cheakers.lowerupper(chars));

System.Console.Write("Enter a number: ");
int integer3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number is {0}\n",
cheakers.PrimeOrNot(integer3));


