//1.	Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.//

public class ejrcicio6
{
    static void Main(string[] args)
    {
        double gradoscelcius, gradosfahrenheit;
        
        


        Console.Write("Ingrese la temperatura en grados celcius: ");
        gradoscelcius = Convert.ToDouble(Console.ReadLine());

        gradosfahrenheit = (((9 * gradoscelcius)/5) + 32);

        Console.Write("La temperatura en grados Fahrenheit es: " + gradosfahrenheit);
    }





}

