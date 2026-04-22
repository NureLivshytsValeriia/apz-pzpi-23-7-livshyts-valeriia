// Цільовий інтерфейс (Target)
interface ITarget
{
    string Request();
}

// Існуючий клас з несумісним інтерфейсом (Adaptee)
class Adaptee
{
    public string SpecificRequest()
    {
        return "Специфічний запит";
    }
}

// Клас Адаптер
class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public string Request()
    {
        // Перетворення виклику
        return "Адаптований: " + adaptee.SpecificRequest();
    }
}

// Клієнт
class Program
{
    static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        Console.WriteLine(target.Request());
    }
}