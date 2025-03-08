using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_IF_y_ElSE
{
    internal class Program
    {
        static void Main()
        {
            

                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("=== Menú de Ejercicios en C# ===");
                    Console.WriteLine("1. Número positivo, negativo o cero");
                    Console.WriteLine("2. Número par o impar");
                    Console.WriteLine("3. Mayor de edad");
                    Console.WriteLine("4. Múltiplo de 5");
                    Console.WriteLine("5. Descuento por edad");
                    Console.WriteLine("6. Calificación aprobatoria");
                    Console.WriteLine("7. Día de la semana");
                    Console.WriteLine("8. Número mayor entre dos");
                    Console.WriteLine("9. Mayor entre tres números");
                    Console.WriteLine("10. Clasificación de ángulos");
                    Console.WriteLine("11. Cálculo de impuestos");
                    Console.WriteLine("12. Clasificación de números");
                    Console.WriteLine("13. Verificacion de año bisiesto");
                    Console.WriteLine("14. Conversión de calificaciones");
                    Console.WriteLine("15. Comparación de tres longitudes");
                    Console.WriteLine("16. Calculadora de descuentos");
                    Console.WriteLine("17. Tipo de triángulo");
                    Console.WriteLine("18. Evaluación de temperatura");
                    Console.WriteLine("19. Conversión de horas a turnos");
                    Console.WriteLine("20. Clasificación de IMC");
                    Console.WriteLine("0. Salir");
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: NumeroPositivoNegativo(); break;
                        case 2: NumeroParImpar(); break;
                        case 3: MayorEdad(); break;
                        case 4: MultiploDe5(); break;
                        case 5: DescuentoEdad(); break;
                        case 6: CalificacionAprobatoria(); break;
                        case 7: DiaDeLaSemana(); break;
                        case 8: NumeroMayorDos(); break;
                        case 9: MayorTresNumeros(); break; 
                        case 10: ClasificacionAngulos(); break;
                        case 11: CalculoImpuestos(); break;
                        case 12: ClasificacionNumeros(); break;
                        case 13: Verificaciónañobisiesto(); break;
                        case 14: ConversionCalificaciones(); break;
                        case 15: ComparacionLongitudes(); break;
                        case 16: CalculadoraDescuentos(); break;
                        case 17: TipoTriangulo(); break;
                        case 18: EvaluacionTemperatura(); break;
                        case 19: ConversionHorasTurnos(); break;
                        case 20: ClasificacionIMC(); break;
                        case 0: Console.WriteLine("Saliendo..."); break;
                        default: Console.WriteLine("Opción no válida."); break;
                    }

                    if (opcion != 0)
                    {
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                    }

                } while (opcion != 0);
            }

        public static void NumeroPositivoNegativo()
            {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
                Console.WriteLine("El número es positivo.");
            else if (numero < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");

        }

        public static void NumeroParImpar()
            {
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("El número es par.");
            else
                Console.WriteLine("El número es impar.");

        }

        public static void MayorEdad()
            {
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
                Console.WriteLine("Eres mayor de edad.");
            else
                Console.WriteLine("Eres menor de edad.");

        }

        public static void MultiploDe5()
            {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 5 == 0)
                Console.WriteLine("El número es múltiplo de 5.");
            else
                Console.WriteLine("El número no es múltiplo de 5.");
        }

        public static void DescuentoEdad()
            {
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 60)
                Console.WriteLine("Aplicas para el descuento del 50%.");
            else
                Console.WriteLine("No aplicas para el descuento.");
        }

        public static void CalificacionAprobatoria()
            {
            Console.Write("Ingresa tu calificación (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());
            if (calificacion >= 60)
                Console.WriteLine("Aprobaste.");
            else
                Console.WriteLine("Reprobaste.");
        }

        public static void DiaDeLaSemana()
            {
            Console.Write("Ingresa un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Número inválido."); break;
            }
        }

        public static void NumeroMayorDos()
            {
            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("El mayor es: " + num1);
            else if (num1 < num2)
                Console.WriteLine("El mayor es: " + num2);
            else
                Console.WriteLine("Ambos números son iguales.");
        }

        public static void MayorTresNumeros()
        {
            Console.Write("Ingresa el primer número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el tercer número: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("El mayor es: " + a);
            else if (b > a && b > c)
                Console.WriteLine("El mayor es: " + b);
            else
                Console.WriteLine("El mayor es: " + c);

        }

        public static void Verificaciónañobisiesto()
        {
            Console.Write("Ingresa un año: ");
            int anio = int.Parse(Console.ReadLine());

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
                Console.WriteLine("El año es bisiesto.");
            else
                Console.WriteLine("El año no es bisiesto.");

        }

        public static void ClasificacionAngulos()
        {
            Console.Write("Ingresa el valor del ángulo en grados: ");
            int angulo = int.Parse(Console.ReadLine());

            if (angulo < 90)
                Console.WriteLine("El ángulo es agudo.");
            else if (angulo == 90)
                Console.WriteLine("El ángulo es recto.");
            else if (angulo > 90 && angulo < 180)
                Console.WriteLine("El ángulo es obtuso.");
            else if (angulo == 180)
                Console.WriteLine("El ángulo es llano.");
            else
                Console.WriteLine("El valor ingresado no es válido.");


        }

        public static void CalculoImpuestos()
        {
            Console.Write("Ingresa tu salario mensual: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            decimal impuesto;

            if (salario < 10000)
                impuesto = 0;
            else if (salario <= 30000)
                impuesto = salario * 0.10m;
            else
                impuesto = salario * 0.20m;

            Console.WriteLine($"Tu impuesto a pagar es: {impuesto:C}");


        }

        public static void ClasificacionNumeros()
        {
            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > 0 && num2 > 0 && num3 > 0)
                Console.WriteLine("Todos los números son positivos.");
            else if (num1 < 0 && num2 < 0 && num3 < 0)
                Console.WriteLine("Todos los números son negativos.");
            else if (num1 == 0 || num2 == 0 || num3 == 0)
                Console.WriteLine("Hay al menos un cero.");
            else
                Console.WriteLine("Los números son mixtos.");


        }

        public static void ConversionCalificaciones()
        {
            Console.Write("Ingresa la calificación numérica (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());
            char letra;

            if (calificacion >= 90)
                letra = 'A';
            else if (calificacion >= 80)
                letra = 'B';
            else if (calificacion >= 70)
                letra = 'C';
            else if (calificacion >= 60)
                letra = 'D';
            else
                letra = 'F';

            Console.WriteLine($"La calificación en letra es: {letra}");


        }

        public static void ComparacionLongitudes()
        {
            Console.Write("Ingresa la primera longitud: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa la segunda longitud: ");
            double lado2 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa la tercera longitud: ");
            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                Console.WriteLine("Los lados forman un triángulo.");
            else
                Console.WriteLine("Los lados no forman un triángulo.");


        }

        public static void CalculadoraDescuentos()
        {
            Console.Write("Ingresa el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            decimal descuento;

            if (precio < 50)
                descuento = 0;
            else if (precio <= 100)
                descuento = precio * 0.05m;
            else
                descuento = precio * 0.10m;

            decimal precioFinal = precio - descuento;
            Console.WriteLine($"El precio final con descuento es: {precioFinal:C}");


        }

        public static void TipoTriangulo()
        {
            Console.Write("Ingresa el primer lado: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo lado: ");
            double lado2 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el tercer lado: ");
            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
                Console.WriteLine("El triángulo es equilátero.");
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                Console.WriteLine("El triángulo es isósceles.");
            else
                Console.WriteLine("El triángulo es escaleno.");


        }

        public static void EvaluacionTemperatura()
        {
            Console.Write("Ingresa la temperatura en grados Celsius: ");
            int temperatura = int.Parse(Console.ReadLine());

            if (temperatura < 0)
                Console.WriteLine("Hace mucho frío.");
            else if (temperatura <= 20)
                Console.WriteLine("Clima fresco.");
            else if (temperatura <= 30)
                Console.WriteLine("Clima agradable.");
            else
                Console.WriteLine("Hace mucho calor.");


        }

        public static void ConversionHorasTurnos()
        {
            Console.Write("Ingresa la hora (0-23): ");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 6 && hora <= 11)
                Console.WriteLine("Es Mañana.");
            else if (hora >= 12 && hora <= 17)
                Console.WriteLine("Es Tarde.");
            else if (hora >= 18 && hora <= 23)
                Console.WriteLine("Es Noche.");
            else if (hora >= 0 && hora <= 5)
                Console.WriteLine("Es Madrugada.");
            else
                Console.WriteLine("Hora inválida.");


        }

        public static void ClasificacionIMC()
        {
            Console.Write("Ingresa tu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingresa tu altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("Bajo peso.");
            else if (imc <= 24.9)
                Console.WriteLine("Normal.");
            else if (imc <= 29.9)
                Console.WriteLine("Sobrepeso.");
            else
                Console.WriteLine("Obesidad.");


        }
    }
}

