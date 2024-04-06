/*
 * Creado por SharpDevelop.
 * Usuario: ferna
 * Fecha: 6/4/2024
 * Hora: 15:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace tp1_com5
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArbolBinario <int> arbolbinarioA = new ArbolBinario<int>(1);
			
			ArbolBinario <int> hijoIZQ = new ArbolBinario<int> (2);
			hijoIZQ.agregarHijoIzquierdo (new ArbolBinario<int>(3));
			hijoIZQ.agregarHijoDerecho (new ArbolBinario<int> (4));
			
			ArbolBinario <int> hijoDER = new ArbolBinario<int> (5);
			hijoDER.agregarHijoIzquierdo (new ArbolBinario<int> (6));
			hijoDER.agregarHijoDerecho (new ArbolBinario<int> (7));
			
			arbolbinarioA.agregarHijoIzquierdo(hijoIZQ);
			arbolbinarioA.agregarHijoDerecho(hijoDER);
			
			
			Console.WriteLine("RECORRIDO PREORDEN");
			arbolbinarioA.preorden();
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("RECORRIDO INORDEN");
			arbolbinarioA.inorden();
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("RECORRIDO POSORDEN");
			arbolbinarioA.postorden();
			Console.WriteLine();
			Console.WriteLine();
			Console.ReadKey(true);
		}
	}
}