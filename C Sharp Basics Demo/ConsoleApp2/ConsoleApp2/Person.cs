using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}

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


