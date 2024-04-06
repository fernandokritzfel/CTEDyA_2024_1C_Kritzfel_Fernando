using System;
	
namespace tp1_com5
{
	public class ArbolBinario<T>
	{
		
	
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public bool esVacioIZQ() {
			return this.hijoIzquierdo==null ;
		}
		public bool esVacioDER() {
			return this.hijoDerecho==null ;
		}
		
		
		
		public void inorden() {
			
				
				// llamada recursiva Hijo IZQ
				if (!this.getHijoIzquierdo().esVacioIZQ())
					this.getHijoIzquierdo().inorden();
				
				//luego de procesa la raiz
				Console.WriteLine(this.getDatoRaiz() + " ");

				// llamadas recursiva Hijo DER
				if (!this.getHijoDerecho().esVacioDER())
					this.getHijoDerecho().inorden();	
		}
		
		public void preorden() {
				//primero de procesa la raiz
				Console.WriteLine(this.getDatoRaiz() + " ");
				
				// llamada recursiva Hijo IZQ
				if (!this.getHijoIzquierdo().esVacioIZQ())
					this.getHijoIzquierdo().preorden();

				// llamadas recursiva Hijo DER
				if (!this.getHijoDerecho().esVacioDER())
					this.getHijoDerecho().preorden();	
								
		}
		
		public void postorden() {
			
				
				// llamada recursiva Hijo IZQ
				if (!this.getHijoIzquierdo().esVacioIZQ())
					this.getHijoIzquierdo().postorden();

				// llamadas recursiva Hijo DER
				if (!this.getHijoDerecho().esVacioDER())
					this.getHijoDerecho().postorden();
				
				//ultimo se procesa la raiz
				Console.WriteLine(this.getDatoRaiz() + " ");
		}
		
		public void recorridoPorNiveles() {
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}
	}
}
