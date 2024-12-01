/*
var newRectangle = new Rectangle(10, 5);
var newRectangleCalc = new RectangleCalculations();

Console.WriteLine($"La base del rectangulo es {newRectangle.Width}");
Console.WriteLine($"La altura del rectangulo es {newRectangle.Height}");
Console.WriteLine($"La circunferencia del rectangulo es {newRectangleCalc.CalculateRectangleCircumference(newRectangle)}");
Console.WriteLine($"El area del rectangulo es {newRectangleCalc.CalculateRectangleArea(newRectangle)}");


Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle (int width, int height)
    {
        Width = width;
        Height = height;
    }
}

class RectangleCalculations
{
    public int CalculateRectangleArea (Rectangle userRectangle)
    {
        return userRectangle.Width * userRectangle.Height;
    }

    public int CalculateRectangleCircumference ( Rectangle userRectangle)
    {
        return userRectangle.Width * 2 + userRectangle.Height * 2; 
    }
}
*/
/*
var userTriangle = new Triangle(15, 12);
Console.WriteLine(userTriangle.CalculateArea());
Console.WriteLine(userTriangle.AsString());

Console.ReadKey();

public class Triangle
{
    private int _base;
    private int _height;

    public Triangle (int @base, int height)
    {
        _base = @base;
        _height = height;
    }

    public int CalculateArea ()
    {
        return (_base * _height) / 2;
    }

    public string AsString ()
    {
        return $"Base is {_base}, Height is {_height}";
    }
}
*/
/*
var userMedicalAppointment = new MedicalAppointment("Alejandro", 
    new DateTime(2025,06,15));
userMedicalAppointment.OverwriteMonthAndDay(1, 6);



Console.ReadKey();

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment (string userPatientName, DateTime userAppointmentDay)
    {
        _patientName = userPatientName;
        _date = userAppointmentDay;
    }

    public void OverwriteMonthAndDay (int month, int day)
    {
        _date = new DateTime (_date.Year, month, day);
    }

    public void MoveByMonthAndDays (int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd);
    }

}
*/
/*
Console.WriteLine("\n");
var human = new LivingOrganism("Alex", true, 2, "Burger", new DateTime(2001,11,2));
Console.WriteLine(human.CreatureBasics());

Console.ReadKey();


class LivingOrganism
{
    private string _name;
    private bool _isAlive;
    private int _legsCount;
    private string _favouriteFood;
    private DateTime _birth;

    public LivingOrganism(string creatureName) :
        this (creatureName, true, 2, "Pizza", DateTime.Now)
    {
    }

    public LivingOrganism (string creatureName, bool isAlive, int legsCount, string favFood, DateTime birth)
    {
        _name = creatureName;
        _isAlive = isAlive;
        _legsCount = legsCount;
        _favouriteFood = favFood;
        _birth = birth;
    }

    public string CreatureBasics()
    {
        return $"Creature name: {_name}, is alive? {_isAlive}, " +
            $"number of legs: {_legsCount}, Favourite food: {_favouriteFood} and" +
            $" was borned in {_birth}";
    }

    public bool KillCreature() => _isAlive = false;
}
*/
/*
var patientApvigo = new MedicalCita(23, new DateTime(2024, 12, 25), "Tos");
Console.WriteLine(patientApvigo.GiveTicket());
patientApvigo.ChangeDate(new DateTime(2025, 1, 1,9,30,00,00));
Console.WriteLine(patientApvigo.GiveTicket());

Console.ReadKey();

public class MedicalCita
{
    private string _patientName;
    private int _age;
    private DateTime _date;
    private string _patology;

    public MedicalCita(int inputAge, DateTime inputDate,
        string inputPatology, string inputPatientName = "Unknown")
    {
        _age = inputAge;
        _date = inputDate;
        _patology = inputPatology;
        _patientName = inputPatientName;
    }

    public string GiveTicket () => $"{_patientName} with age of {_age} must be at hospital at" +
            $" {_date} to check the {_patology}";

    public void ChangeDate(DateTime newInputDate) => _date = newInputDate; 
}
*/
/*
var dogLucky = new Dog("Lucky", "german shepherd", 65);
Console.WriteLine(dogLucky.Describe());

var dogFlaki = new Dog("Flaki", 16);
Console.WriteLine(dogFlaki.Describe());

Console.ReadKey();
public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;
    private string _size;

    public Dog(string dogName, int dogWeight)
    {
        _name = dogName;
        _weight = dogWeight;
        _breed = "mixed-breed";
    }

    public Dog(string dogName, string dogBreed, int dogWeight)
    {
        _name = dogName;
        _breed = dogBreed;
        _weight = dogWeight;
        DogSize();
    }

    private void DogSize()
    {
        if (_weight < 5) _size = "tiny";
        else if (_weight >= 5 && _weight< 30) _size = "medium";
        else _size = "large";
    }

    public string Describe () => $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {_size} dog.";
}
*/

/*
using System.Reflection.Metadata.Ecma335;

var CanchaDeFutbol = new Rectangle(10,20);
Console.WriteLine(CanchaDeFutbol.Width);
CanchaDeFutbol.Width = 30;
Console.WriteLine(CanchaDeFutbol.Width);
Console.WriteLine(CanchaDeFutbol.RectangleArea());

Console.ReadKey();


public class Rectangle
{
    public int Height;
    private int _width;

    public Rectangle(int width, int height)
    {
        _width = MinLengthValidation(width);
        Height = MinLengthValidation(height);
    }

    
    public int Width
    {
        get => _width;
        set
        {
            if(value > 0) _width = value;
        }
    }

    public int RectangleArea () => _width * Height;

    private int MinLengthValidation (int widthOrHeight)
    {
        if (widthOrHeight <= 0) return 1;
        return widthOrHeight;
    }
}
*/

/*
var fechaPasada = new DateTime(1999, 12, 31);
var fechaTomorrow = new DateTime(2024, 12, 1);

var nuevoPedidoCarlos = new Order("Alargador de pene", fechaTomorrow);
Console.WriteLine(nuevoPedidoCarlos.GiveInformation());

Console.ReadKey();

public class Order
{
    public Order (string item, DateTime orderDate)
    {
        Item = item;
        Date = orderDate;
    }

    public string Item { get; }
    private DateTime _date;

    public DateTime Date
    {
        get => _date;
        set 
        {
            if (value.Year == 2024) _date = value;
        }
    }

    public string GiveInformation() => $"El pedido de '{Item}' llega el {Date}";
}
*/
/*
class DailyAccountState
{
    private int _initialState { get; }
    private int _sumOfOperations { get; }

    public DailyAccountState(int initialState, int sumOfOperations)
    {
        _initialState = initialState;
        _sumOfOperations = sumOfOperations;
    }

    public int EndOfDayState => _initialState + _sumOfOperations;
    public String Report => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {_initialState}, end of day state: {EndOfDayState}";
}
*/

/*
Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

Console.ReadKey();
static class Calculator
{
    public static int Add(int a, int b) => a + b + sumar;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

    public const int sumar = 2;
}
*/

//Console.WriteLine($"Today is {NumberToDayOfWeekTranslator.Translate(6)}");

//Console.ReadKey();
//public static class NumberToDayOfWeekTranslator
//{
//    public static string Translate(int numberOfTheWeek)
//    {
//        switch (numberOfTheWeek)
//        {
//            case 1:
//                return "Monday";
//            case 2:
//                return "Tuesday";
//            case 3:
//                return "Wednesday";
//            case 4:
//                return "Thursday";
//            case 5:
//                return "Friday";
//            case 6:
//                return "Saturday";
//            case 7:
//                return "Sunday";
//            default:
//                return "Invalid day of the week";
//        }
//    }
//}

//var newCuadrado = new Square(5, 8);
//var newCuadradoDOs = new Square(5, 0);
//Console.WriteLine($"Square instances: {Square.CountOfSquareInstances}");

//Console.ReadKey();

//public class Square
//{
//    private int _height;
//    private int _width;
//    public static int CountOfSquareInstances {  get; private set; }

//    public Square (int height, int width)
//    {
//        Height = height; 
//        _width = width;
//        CountOfSquareInstances++;
//    }

//    private const int defaultValue = 1;

//    public int Height
//    {
//        get => _height;
//        set
//        {
//            if (_height > 0) { _height = Height; }
//            else { _height = defaultValue; }
//        }
//    }
//    public int Width
//    {
//        get => _width;
//        set { 
//            if (Width > 0) _width = Width;
//            else { _width = defaultValue; }
//        }
//    }
//} 

/*
Console.WriteLine(StringsTransformator.TransformSeparators("this,is,some,string", ",", "+"));

Console.ReadKey();

public static class StringsTransformator
{
    public static string TransformSeparators(
        string input, 
        string originalSeparator, 
        string targetSeparator)
    {
        string output = "";
        foreach (char c in input)
        {
            if(c == Char.Parse(originalSeparator))
            {
                output += targetSeparator;
                continue;
            }
            output += c;
        }
        return output;
    }
}
*/

//var JoseDiaz = new Human(22, "Josete");
//Console.WriteLine(JoseDiaz.Name);

//var AlexPvigo = new Human(23, "Alexito");
//Console.WriteLine(AlexPvigo.Name);

//Console.WriteLine(Human._countOfHumanInstasnces);

//Console.ReadKey();

//public class Human {

//    private int _age;
//    public string Name { get; }

//    public static int _countOfHumanInstasnces;

//    public Human(int newHumanAge, string newHumanName)
//    {
//        Age = newHumanAge;
//        Name = newHumanName;
//        ++_countOfHumanInstasnces;
//    }

//    public int Age
//    {
//        get => _age;
//        set 
//        {
//            if (Age > 0) _age = Age;
//            else _age = 0;
//        }
//    }
//}

