
using System;

namespace CSharpFundamentals
{
    public class Person1
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            var person = new Person1() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person1 person)
        {
            person.Age += 10;
        }
    }
}
    
        
/*public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail=2,
        Express=3
    }
   


var a = 10;
var b = a;
b++;
Console.WriteLine(string.Format("a:{0},b:{1}", a, b));
var array1 = new int[3] { 1, 2, 3 };
var array2 = array1;
array2[0] = 0;
Console.WriteLine(string.Format("array1[0]:{0},array2[0]:{1}", array1[0], array2[0]));


Enums
var method = ShippingMethod.Express;
Console.WriteLine((int)method);

var methodId = 3;
Console.WriteLine((ShippingMethod)methodId);
Console.WriteLine(method.ToString());
var methodNmae = "Meenu";
var shippingMethod= (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodNmae)

/*var firstName = "Mosh";
String lastName = "Hawai";
var fullName = firstName + " " + lastName;
var myFullName = string.Format("My  name is {0} {1}", firstName, lastName);
var names = new string[3] { "John", "Jack", "Harry" };
var formattedNames = string.Join(",", names);
Console.WriteLine(formattedNames);

var text = @"Hi John
Look into the following paths
c:\\folder1\\folder2
c:\\folder3\\folder4";
Console.WriteLine(text);


var numbers = new int[3];
numbers[0] = 1;
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);
var flags = new bool[3];
flags[0] = true;
Console.WriteLine(flags[0]);
Console.WriteLine(flags[1]);
Console.WriteLine(flags[2]);

var names = new string[3]
{
    "Jack","John","Mary"
};
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
var john = new Person();
john.FirstName = "John";
john.LastName = "Daniel";
john.Introduce();
Calculator calculator = new Calculator();
var result=calculator.Add(1, 2);
Console.WriteLine(result);*/



/* var number=2;
 var count = 10;
 var totalPrice = 20.95f;
 var character = 'A';
 var firstName = "Mosh";
 var isWorking = false;
 Console.WriteLine(number);
 Console.WriteLine(count);
 Console.WriteLine(totalPrice);
 Console.WriteLine(character);
 Console.WriteLine(firstName);
 Console.WriteLine(isWorking);
 Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue); 
 Console.WriteLine("{0} {1}",float.MinValue, float.MaxValue);
const float Pi = 3.14f; by using const we cannot change the values*/

/* byte b = 1;
 int i = b;
 Console.WriteLine(i);*/

/*Some Bytes are lost here
 int i = 1000;
 byte b = (byte) i;
 Console.WriteLine(b);*/



/*var number = "1234";
int i = Convert.ToInt32(number);
Console.WriteLine(i); 
try
{
    Conrversion of string to byte
    var number = "1234";
    byte b = Convert.ToByte(number);
    Console.WriteLine(b);
}
catch (Exception)
{
    Console.WriteLine("The number couldnot be converrted to byte");

}

try
{
    string str = "true";
   bool b = Convert.ToBoolean(str);
    Console.WriteLine(b);
}
catch (Exception)
{
    Console.WriteLine("The number couldnot be converrted to byte");

}
var a=1;
var b=2;
var c = 3;
Console.WriteLine(a + b);
Console.WriteLine((float)a / (float)b);
Console.WriteLine((a + b )* c);
Console.WriteLine(a>b);
Console.WriteLine(a==b);
Console.WriteLine(a!=b);
Console.WriteLine(!(a!=b));
Console.WriteLine(a==b);
Console.WriteLine(c>b && c>a);
Console.WriteLine(c>b && c==a);
Console.WriteLine(c>b || c==a);
Console.WriteLine(!(c>b || c==a));*/


