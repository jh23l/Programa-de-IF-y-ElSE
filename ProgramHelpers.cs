using System;

internal static class ProgramHelpers
{
    static void Main()
    {
        {
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
                    Console.WriteLine("13. Conversión de calificaciones");
                    Console.WriteLine("14. Comparación de tres longitudes");
                    Console.WriteLine("15. Calculadora de descuentos");
                    Console.WriteLine("16. Tipo de triángulo");
                    Console.WriteLine("17. Evaluación de temperatura");
                    Console.WriteLine("18. Conversión de horas a turnos");
                    Console.WriteLine("19. Clasificación de IMC");
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
                        case 13: ConversionCalificaciones(); break;
                        case 14: ComparacionLongitudes(); break;
                        case 15: CalculadoraDescuentos(); break;
                        case 16: TipoTriangulo(); break;
                        case 17: EvaluacionTemperatura(); break;
                        case 18: ConversionHorasTurnos(); break;
                        case 19: ClasificacionIMC(); break;
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
}