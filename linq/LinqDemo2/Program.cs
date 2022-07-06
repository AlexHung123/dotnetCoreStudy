// See https://aka.ms/new-console-template for more information
using LinqDemo2;

Console.WriteLine("Hello, World!");

List<Employee> list = new List<Employee>();
list.Add(new Employee { Id = 1, Name = "jerry", Age = 28, Gender = true, Salary = 5000 });
list.Add(new Employee { Id = 2, Name = "jim", Age = 33, Gender = true, Salary = 3000 });
list.Add(new Employee { Id = 3, Name = "lily", Age = 35, Gender = false, Salary = 9000 });
list.Add(new Employee { Id = 4, Name = "lucy", Age = 16, Gender = false, Salary = 2000 });
list.Add(new Employee { Id = 5, Name = "kimi", Age = 25, Gender = true, Salary = 1000 });
list.Add(new Employee { Id = 6, Name = "nancy", Age = 35, Gender = false, Salary = 8000 });
list.Add(new Employee { Id = 7, Name = "zack", Age = 35, Gender = true, Salary = 8500 });
list.Add(new Employee { Id = 8, Name = "jack", Age = 33, Gender = true, Salary = 8000 });

// IEnumerable<Employee> items = list.Where(i=>i.Age > 30);

// foreach (Employee employee in items){
//     System.Console.WriteLine(employee.Name);
// }

// System.Console.WriteLine(list.Any(i=> i.Age > 30));

// Employee employee = list.SingleOrDefault(i => i.Age > 50);

// var items = list.Skip(3).Take(2);

// foreach (var item in items){
//     System.Console.WriteLine(item?.Name);
// }

// var item = list.Max(i=>i.Salary);
// System.Console.WriteLine(item);

// double a = list.Where(i=>i.Age > 30).Average(i=>i.Age);

// IEnumerable<IGrouping<int, Employee>> items = list.GroupBy(i=>i.Age);

// foreach(IGrouping<int, Employee> item in items){
//     System.Console.WriteLine(item.Key);

//     System.Console.WriteLine(item.Max(i=>i.Salary));

//     foreach(Employee e in item){
//         System.Console.WriteLine(e);
//     }
// }

// IEnumerable<int> ages = list.Select(i=>i.Age);
// foreach(int i in ages){
//     System.Console.WriteLine(i);
// }

// IEnumerable<Dog> item1 = list.Select(i=>new Dog{
//     NickName = i.Name,
//     Age = i.Age,
// });

// foreach(Dog child in item1){
//     System.Console.WriteLine(child.NickName);
// }

// var item2 = list.Select(e=>new { 
//     Name = e.Name,
//     Age = e.Age,
// });

// foreach (var item in item2){
//     System.Console.WriteLine(item.Name);
// }

// var items1 = list.GroupBy(x => x.Age).Select(g =>new { 
//     Name = g.Key, 
//     MaxSalary = g.Max(e=>e.Salary), 
//     MinSalary = g.Min(e=>e.Salary),
//     Count = g.Count()
//     });

// foreach (var item in items1){
//     System.Console.WriteLine(item.Name + "," + item.MaxSalary + "," + item.MinSalary + "," + item.Count);
// }

// var items1 = list.Where(i=>i.Salary > 6000);
// List<Employee> list2 = items1.ToList();
// Employee[] array2 = items1.ToArray();

// //IEnumerable<IGrouping<int, Employee>>
// var g = list.Where(i=>i.Id > 2).GroupBy(i=>i.Age)
// .OrderBy(g=>g.Key).Take(3)
// .Select(g=>new {
//     Age = g.Key,
//     Count = g.Count(),
//     Salary = g.Average(i=>i.Salary)
// });

// foreach (var i in g){
//     System.Console.WriteLine(i.Age + " " + i.Count + " " + i.Salary);
// }

// var items2 = from e in list
//              where e.Salary > 5000
//              select new {e.Salary, e.Age, e.Id};

// foreach (var item in items2){
//     System.Console.WriteLine(item.Salary);
// }








