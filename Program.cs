using ClassLibrary1;
using RandomPractices;

internal class Program
{
    private static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber1 s1 = new("Sub1", 1);
        Subscriber2 s2 = new("Sub2", 2);
        List<Object> list = new List<Object>() { s1, s2 };

        publisher.EventName += s1.EventHandler;
        publisher.EventName += s2.EventHandler;

        //tried to make an extra anonym event. it works, but called 2 times without the if
        //publisher.EventName += (Object obj) =>
        //{
        //    if(obj is Subscriber1)
        //    {
        //        Subscriber1 s3 = new Subscriber1("sub3", 5);
        //        Console.WriteLine(s3.Name + " " + s3.Age);
        //    }
        //};

        foreach (Object obj in list)
        {
            publisher.RaiseEvent(obj);
        }
    }
}