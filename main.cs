using System;

public class Test
{
	public string str = string.Empty;
	
	public Test()
	{
	}
	
	public void func(int a, string b)
	{
		Console.WriteLine(" a = {a}, b = {b} ",a, b);
	}
	
	public int autofunc{get; set;}
	
	private int myvar;
	
	public int myproperty{
		get {return myvar + 1; }
		set { myvar = value; }
	}
	
	public static void Main(string[] args){
		Test t = new Test();
		t.myproperty = 10;
		Console.WriteLine(t.myproperty);
	}
}

// Create a class Car

public class Car
{
    public Car(){

    }

    private string company, name, type, color;
	private int mileage;

    public string Company{
        get { return company;}
        set { company = value; }
    }

    public string Name{
        get { return name;}
        set { name = value; }
    }

    public string Type{
        get { return type; }
        set { type = value; }
    }
    public string color{
        get { return color; }
        set { color = value;}
    }

    public int Mileage{
        get { return mileage;}
        set { mileage = value; }
    }
    
    public static void Main(string[] args){
        Car c = new Car();
        c.Name = "XUV500 ";
        c.Company = "Mahindra ";
        c.Type = "SUV ";
        c.Mileage = 15;
        c.color = "black";

        Console.WriteLine(c.Company + c.Name + c.Type + c.color + c.Mileage);
        
    }
}

// if-else Statement

if (i < j)
{
    Console.WriteLine("i is less than j");
}
else if (i > j)
{
    Console.WriteLine("i is greater j");
}
else
{
    Console.WriteLine("i is equal to j");
}

// Ternary Operator

// switch
switch(i)
{
    case 'a':
        Console.WriteLine("case A");
        break;
    case 'b':
        Console.WriteLine("Case B");
        break;
    default:
        Console.WriteLine("Default Case");
        break;
}

// here for 'b' and 'c' will execute the same condition
switch(i)
{
    case 'a':
        Console.WriteLine("case A");
        break;
    case 'b':
    case 'c':
        Console.WriteLine("Case B");
        break;
    default:
        Console.WriteLine("Default Case");
        break;
}

// for Loop
for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

// can also use decimal, for the for Loop
for (double d = 1.01D; d < 1.10; d+= 0.01D)
{
    Console.WriteLine(d);
}

// infinte Loop
int i = 0
for(; ; )
{
    if (i < 10)
    {
        Console.WriteLine(i);
        i++;
    }
    else
    {
        break;
    }
}

// multiple Variables in the For Loop
 for(int i = 0, j = 0; i + j < 5; i++, j++)
{
    Console.WriteLine(i+j);
}