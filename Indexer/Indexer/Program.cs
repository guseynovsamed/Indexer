


#region Task1
//DataList<Person> dataList = new();

//dataList.Add(new Person { Name = "Tünzale", Surname = "Memmedova", Age = 23, Id = 1 });
//dataList.Add(new Person { Name = "Besir", Surname = "Temirli", Age = 24, Id = 2 });
//dataList.Add(new Person { Name = "Elnur", Surname = "Memmedov", Age = 20, Id = 3 });

//Console.WriteLine("Please add ID:");
//int id = int.Parse(Console.ReadLine());

//var result = dataList.GetById(id);

//Console.WriteLine(result.Name + " " + result.Surname + " " + result.Age);
#endregion

#region Task2
//DataList<Person> dataList = new();

//dataList.Add(new Person { Name = "Tünzale", Surname = "Memmedova", Age = 23, Id = 1 });
//dataList.Add(new Person { Name = "Besir", Surname = "Temirli", Age = 24, Id = 2 });
//dataList.Add(new Person { Name = "Elnur", Surname = "Memmedov", Age = 20, Id = 3 });

//Console.WriteLine("Please add ID");
//int number = int.Parse(Console.ReadLine());

//var result = dataList.Remove(number);

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name + " " + item.Surname);
//}
#endregion

#region Task3
using Indexer;
using Indexer.Exceptions;
using Indexer.Models;

static void GetFactorial(int n)
{

    try
    {
        int number = 1;
        while (n != 1)
        {
            number = number * n;
            n = n - 1;
        }

        if (number > 1)
        {
            Console.WriteLine(number);
        }
        else
        {
            throw new FactorialExceptions("Operation is incorrect");
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }

}

//GetFactorial(-8);



#endregion
