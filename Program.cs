using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Clasificación de Triángulos");
        Console.WriteLine("---------------------------");

        // Solicitar al usuario la longitud de los lados del triángulo
        Console.Write("Ingrese la longitud del primer lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la longitud del segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la longitud del tercer lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Clasificar el triángulo
        string tipoTriangulo = ClasificarTriangulo(lado1, lado2, lado3);

        // Mostrar el resultado
        Console.WriteLine($"El triángulo con lados {lado1}, {lado2} y {lado3} es: {tipoTriangulo}");

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static string ClasificarTriangulo(double lado1, double lado2, double lado3)
    {
        // Validar si los lados pueden formar un triángulo
        if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 ||
            lado1 + lado2 <= lado3 ||
            lado1 + lado3 <= lado2 ||
            lado2 + lado3 <= lado1)
        {
            return "No es un triángulo válido.";
        }

        // Clasificación del triángulo
        switch (true)
        {
            case bool _ when lado1 == lado2 && lado2 == lado3:
                return "Equilátero";
            case bool _ when lado1 == lado2 || lado1 == lado3 || lado2 == lado3:
                return "Isósceles";
            default:
                return "Escaleno";
        }
    }
}
