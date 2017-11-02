using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleccion
{
	class Program
	{
		static void Main(string[] args )
		{
			Console.WriteLine("METODO DE SELECCION");
			int[] numeros = { 34, 56, 76, 87, 90, 1 };
			int x,y , minimo, auxiliar;

			// Para todos los datos del array
			for (x = 0; x < numeros.Length - 1; x++)
			{
				// se va organizando pero iniciando con el menor
				minimo = x;
				for (y = x + 1; y < numeros.Length; y++)// en est for  y = contador  tendra un valor mas que el primero o sea x
				{
					if (numeros[y] < numeros[minimo])
						minimo = y;
				}

				// 
				if (minimo != x)
				{
					auxiliar = numeros[x];
					numeros[x] = numeros[minimo];
					numeros[minimo] = auxiliar;
				}

				// Y muestro el progreso
				foreach (int dato in numeros)
					Console.Write(dato + " ");
				Console.WriteLine();
				Console.Read();
			}
		}
	}
}

