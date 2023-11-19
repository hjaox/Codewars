namespace CSharp._8kyu;

public class Human
{
}

public class Man : Human
{
}

public class Woman : Human
{
}

public class BasicSubclassesAdamAndEve
{

    public static Human[] Create()
    {
        return new Human[] { new Man(), new Woman() };
    }
}