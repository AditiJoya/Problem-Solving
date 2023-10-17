// See https://aka.ms/new-console-template for more information
using _5thclassCalculator;

Console.WriteLine("Hello, World!");
Calculator cal = new Calculator();
double n1 = Convert.ToDouble(Console.ReadLine());
double n2 = Convert.ToDouble(Console.ReadLine());
//string opt = Console.ReadLine();
//Console.WriteLine(cal.MyValue(n1, n2, opt));
Console.WriteLine(cal.Add(n1,n2));
Console.WriteLine(cal.Subs(n1,n2));
Console.WriteLine(cal.Multi(n1, n2));
Console.WriteLine(cal.Div(n1, n2));
List<Customer> c = new List<Customer>()
{ new Customer { Id=1,Name="sumon",Address="Dhanmondi",City="Dhaka"},
new Customer{Id=2,Name="Rabbi",Address="Mirpur",City="Dhaka"},
new Customer{Id=3,Name="Hasan",Address="Mirpur",City="Dhaka"},
new Customer{Id=4,Name="Kabir",Address="Benapol",City="Jessore"}
};
var x = from d in c
        where d.City == "Dhaka"
        select d;
foreach (Customer cust in x)
{
    Console.WriteLine( cust.Name, cust.Address,cust.City);
}
