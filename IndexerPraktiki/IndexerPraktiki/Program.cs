


using IndexerPraktiki;
using IndexerPraktiki.Controllers;
using IndexerPraktiki.Exceptions;
using IndexerPraktiki.Helpers.Constants;
#region Indexer
//Library library = new Library();

//Book book = new Book();
//book.Id = 1;

//book.Name = "Test1";

//library[0] = book;


//Console.WriteLine(library[0].Name);
#endregion




#region Exceptions

//try
//{
//    int[] nums = new int[0];

//    nums[2] = 1000;
//    int a = 5;
//    int b = 0;

//    int result = a / b;

//    Console.WriteLine(result);


//}
//catch (DivideByZeroException ex)
//{

//    Console.WriteLine(ex.Message);
//}
//catch (NullReferenceException ex)
//{

//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{

//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Salam");
//}



static void Register(string userName, string password)
{
    bool isSuccess = false;
    try
    {
        if (userName == "Semed134")
        {
            Console.WriteLine("Register success");
            isSuccess = true;
        }
        else
        {
            throw new RegisterFailedException("Register failed custom");
        }

    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
    finally
    {
        SendEmail(isSuccess);
    }
}

//Register("sededjn","aeuhfeu");


static void SendEmail(bool isSuccess)
{
    if (isSuccess)
    {
        Console.WriteLine(AccountMessages.EmailSuccess);
    }
    else
    {
        Console.WriteLine(AccountMessages.RegisterFaild);
    }
}
#endregion



//ShowText("Salamlar");

//static void ShowText(string text)
//{
//    try
//    {
//        if (text is null)
//        {
//            throw new ArgumentNullException();
//        }
//        else
//        {
//            Console.WriteLine(text);
//        }

//    }
//    catch (Exception ex )
//    {

//        Console.WriteLine(ex.Message);
//    }
    

//}



PersonController personController = new PersonController();

personController.GetById();
