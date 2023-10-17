// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//input grade,if get minus values then loop end and find avg from  min and max valus of this list.
List<double> gradelist= new List<double>();
double grade;
bool parseOkay;
Console.WriteLine("Enter Grade:   ");
parseOkay=double.TryParse(Console.ReadLine(), out grade);
while (parseOkay!=true) {
    Console.WriteLine("envalid entry try again");
    parseOkay = double.TryParse(Console.ReadLine(), out grade);

}

while(grade>=0)
{
    gradelist.Add(grade);
    Console.WriteLine("Enter Grade:   ");
    parseOkay = double.TryParse(Console.ReadLine(), out grade);
    while (parseOkay != true)
    {
        Console.WriteLine("envalid entry try again");
        parseOkay = double.TryParse(Console.ReadLine(), out grade);

    }

}
Console.WriteLine("gradeList are:     ");
double sum = 0;
for (int i = 0; i < gradelist.Count; i++)
{
     sum = sum + gradelist[i];
    Console.WriteLine(gradelist[i]);
}
double max = gradelist[0];
double min = gradelist[0];
int count = 0;
for (int i = 0;i < gradelist.Count; i++)
{
    count++;
    if (max < gradelist[i])
    { 
        max = gradelist[i];

    }

    if (min > gradelist[i])
    {
        min = gradelist[i];

    }

}
Console.WriteLine("max value is: {0}",max);
Console.WriteLine("min value is: {0}", min);
Console.WriteLine("count {0}",count);
Console.WriteLine("sum {0}", sum);

if (count > 2)
{

    double average = 0;
    average = (max + min) / 2;
    Console.WriteLine("Avarage of Min & Max value:    ");

    Console.WriteLine("{0} + {1} / 2 = {2}", max, min, average.ToString());
    Double avg2 = (gradelist.Sum() - gradelist.Max() - gradelist.Min()) / (gradelist.Count - 2);
    Console.WriteLine("avarage value using LINQ:  ");
    Console.WriteLine( avg2);
   

}
else
{
    Console.WriteLine("Please Enter Too few grades for avg");

    Console.WriteLine("Enter Grade:   ");
    parseOkay = double.TryParse(Console.ReadLine(), out grade);
    while (parseOkay != true)
    {
        Console.WriteLine("envalid entry try again");
        parseOkay = double.TryParse(Console.ReadLine(), out grade);

    }

    while (grade >= 0)
    {
        gradelist.Add(grade);
        Console.WriteLine("Enter Grade:   ");
        parseOkay = double.TryParse(Console.ReadLine(), out grade);
        while (parseOkay != true)
        {
            Console.WriteLine("envalid entry try again");
            parseOkay = double.TryParse(Console.ReadLine(), out grade);

        }

    }
    Console.WriteLine("gradeList are:     ");
   
    for (int i = 0; i < gradelist.Count; i++)
    {
        sum = sum + gradelist[i];
        Console.WriteLine(gradelist[i]);
    }
     max = gradelist[0];
     min = gradelist[0];
     count = 0;
    for (int i = 0; i < gradelist.Count; i++)
    {
        count++;
        if (max < gradelist[i])
        {
            max = gradelist[i];

        }

        if (min > gradelist[i])
        {
            min = gradelist[i];

        }

    }
    Console.WriteLine("max value is: {0}", max);
    Console.WriteLine("min value is: {0}", min);
    Console.WriteLine("count {0}", count);
    Console.WriteLine("sum {0}", sum);

    if (count > 2)
    {

        double average = 0;
        average = (max + min) / 2;
        Console.WriteLine("Avarage of Min & Max value:    ");

        Console.WriteLine("{0} + {1} / 2 = {2}", max, min, average.ToString());
        Double avg2 = (gradelist.Sum() - gradelist.Max() - gradelist.Min()) / (gradelist.Count - 2);
        Console.WriteLine("avarage value using LINQ:  ");
        Console.WriteLine(avg2);

    }

}

