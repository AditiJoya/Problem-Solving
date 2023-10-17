// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using _6thClass;

Console.WriteLine("Hello, World!");
List<Student> st = new List<Student>()
{
    new Student {studentid= 1,studentname="adi",phone="0123456",city="dhaka",age=40,courseid=1},
    new Student {studentid= 2,studentname="dani",phone="0123456",city="manikgang",age=50,courseid=2},
    new Student {studentid= 3,studentname="apu",phone="0123456",city="dhaka",age=70,courseid=3},
    new Student {studentid= 4,studentname="Tom",phone="0123456",city="comilla",age=60,courseid=4}
};
List<Course> courses = new List<Course>()
{
    new Course{courseid=1,coursename="VB",fees=30000},
    new Course{courseid=2,coursename="C#.Net",fees=35000},
    new Course{courseid=3,coursename="SQL Server",fees=40000},
    new Course{courseid=4,coursename="Oracle",fees=50000},
};
var courseinfo = from s in st
                 join c in courses on s.courseid equals c.courseid
                 select new { s.studentid, s.studentname, s.age, c.coursename, c.fees };

foreach(var a in courseinfo)
{
    Console.WriteLine("ID: {0}  Name:{1}  Age{2}  CName:{3} Fees{4}", a.studentid,a.studentname,a.age,a.coursename,a.fees);
}


//var mystudent =from s in st
//               where s.city=="dhaka" && s.age>=40
//    select new {s.studentid,s.studentname,s.phone,s.city,s.age};
//foreach(var a in mystudent)
//{
//    Console.WriteLine( "id:{0}  Name:  {1}  Phone: {2} City{3}  Age:{4}",a.studentid.ToString(),a.studentname,a.phone,a.city,a.age);
//}