class PersonFactory { 
    public static void Main(string[] args)
    {
        string message = "App Executed successfully";
        ConsoleLogger cl = new ConsoleLogger();
        cl.Log(message);

        PersonLogger lg=new PersonLogger();
        lg.Log(message);
    }     
}

class PersonLogger : Logger
{
    public void Log(string msg)
    {
        File.Create("C:\\Users\\NAV\\Desktop\\dams.txt");
        File.AppendText(msg);
    }
}
class ConsoleLogger : Logger
{
    public void Log(string msg)
    {
        Console.WriteLine(msg);
    }
}

public interface Logger
{
    public void Log(string msg);
}