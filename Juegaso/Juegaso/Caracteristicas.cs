using System;

namespace Juegaso
{
	public class Caracteristicas
	{
		private string nombre;
		private int vida;
		private int danio;

		public string Nombre {
			get {
				return this.nombre;
			}
			set {
				this.nombre = value;
			}
		}

		public int Vida{
			get {
				return this.vida;
			}
			set {
				this.vida = value;
			}
		}

		public int Danio{
			get {
				return this.danio;
			}
			set {
				this.danio = value;
			}
		}

		public Caracteristicas (string nombre="Batman", int vida=100, int danio=10)
		{
			this.nombre = nombre;
			this.danio = danio;
			this.vida = vida;
		}
	}
}