// See https://aka.ms/new-console-template for more information
using _7thclass;

Console.WriteLine("Hello, World!");
List<Employee> emp = new List<Employee>()
{new Employee {empid=1,empname="adi",age=10,depid=1},
new Employee {empid=2,empname="adi",age=10,depid=2},
new Employee {empid=3,empname="adi",age=10,depid=3},
new Employee {empid=4,empname="adi",age=10,depid=4}
};
List<Dept> dept = new List<Dept>()
{ new Dept{depid=1,depname="it"},
new Dept{depid=1,depname="it"},
new Dept{depid=1,depname="it"}
};

var empinfo = from e in emp
              join d in dept on e.depid equals d.depid
              select new { e.empid, e.empname, e.age, e.pf, e.fa, e.ma,e.total, d.depid, d.depname };
foreach(var k in empinfo)
{
    double basic = (k.depname == "it") ? 50000 : 40000;
    double fa = 50000;
    double ma = basic;
    double pf = basic;
    double total = fa + ma + pf;



    Console.WriteLine("Id: {0}  Name: {1}  age: {2} PF: {3} MA: {4} FA:{5} TOTAL: {6} DEPID: {7} DEPNAME: {8} ", k.empid,
            k.empname, k.age, pf, ma, fa, total, k.depid, k.depname);
}