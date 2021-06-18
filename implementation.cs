public interface IA
{
    string GetData();
}

public interface IB
{
    string GetData();
}

public class C : IA, IB
{
    string IA.GetData()
    {
        return "A";
    }

    string IB.GetData()
    {
        return "B";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var c = new C();
        
        Console.WriteLine(((IA) c).GetData());

        Console.WriteLine(((IB) c).GetData());

        Console.WriteLine(c.GetData());
    }
}