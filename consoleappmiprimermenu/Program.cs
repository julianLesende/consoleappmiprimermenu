using System;

namespace primermenu
{
	class Program
	{
		static void Main(string[] args)
		{
			{
				double distancia;
				double opcion;
				double tiempo;
				double velocidad;
				Console.WriteLine("*******bienvenido que operacion desea investigar?*******");

				Console.WriteLine("1-averiguar la velocidad");

				Console.WriteLine("2-averiguar  la distancia");

				Console.WriteLine("3-averiguar el tiempo");

				Console.WriteLine("4-salir");

				Console.Write("elija la operacion que desee: ");

				opcion = Double.Parse(Console.ReadLine());
				if (opcion == 1)
				{
					Console.Write("ingrese la distancia en km: ");

					distancia = Double.Parse(Console.ReadLine());

					Console.Write("ingrese el tiempo en horas");

					tiempo = Double.Parse(Console.ReadLine());

					velocidad = distancia / tiempo;

					Console.Write("la velocidad es de: " + velocidad + "km/h");
				}
				else
				{
					if (opcion == 2)
					{
						Console.Write("ingrese la velocidad en km/h: ");

						velocidad = Double.Parse(Console.ReadLine());

						Console.Write("ingrese el tiempo en horas");

						tiempo = Double.Parse(Console.ReadLine());

						distancia = velocidad * tiempo;

						Console.Write("la distancia recorrida es de:" + distancia + " km");

					}
					else
					{
						if (opcion == 3)
						{
							Console.Write("ingrese la distancia en km: ");

							distancia = Double.Parse(Console.ReadLine());

							Console.Write("ingrese el velocidad en km/h");

							velocidad = Double.Parse(Console.ReadLine());

							tiempo = distancia / velocidad;

							Console.Write("el tiempo recorrida es de:" + tiempo + " horas");
						}
						else
						{
							if (opcion == 4)
							{
								Console.Clear();
							}
						}
					}
				}
			}
		}
	}
}