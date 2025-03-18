namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
public class Product
{
    public string name;
    public string description;
    public int count;
    public bool isStock;
    public double price;

    public Product(string name, string description, int count, bool isStock, double price)
    {
        this.name = name;
        this.description = description;
        this.count = count;
        this.isStock = isStock;
        this.price = price;
    }
    public double Price{ 
        get
        { return price;
        } 
        set 
        { price = value; } 
    }
    public void Sale()
    {
        if (isStock && count > 0)
        {
            count--;
            Console.Writeline("satis ugurlu oldu" + count);
        }
        if (count == 0)
        {
            isStock = false;
        }
    }
        else
        {
            System.Console.WriteLine("Mehsul yoxdur.");
        }
    }
}
        public class Notebook : Product
    {
       public byte ram;
        public int storage;

        public Notebook(string name, string description, int count, bool isStock, double price, byte ram, int storage)
            : base(name, description, count, isStock, price)
        {
            this.ram = ram;
            this.storage = storage;
        }
        public byte RAM
        {
            get
            { return ram; }
            set
            {
                if (value > 0)
                    ram = value;
                else
                  Console.WriteLine("RAM menfi ola bilmezz");
            }
        }

        public int Storage
        {
            get { return storage; }
            set { storage = value; }
        }
    public string GetFullInfo()
    {
        return name + " - " + description + " - Qiymet: " + Price + " - RAM: " + ram + " GB: " + storage + " GB";
    }

    public void ShowFullData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Description: " + description);
        Console.WriteLine("Qiymet: " + Price);
        Console.WriteLine("Count: " + count);
        Console.WriteLine("RAM: " + ram + " GB");
        Console.WriteLine(": " + storage + " GB");
    }

}
}

