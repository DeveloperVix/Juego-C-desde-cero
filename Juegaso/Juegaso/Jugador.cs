using System;

namespace Juegaso
{
	public class Jugador : Caracteristicas
	{
		public Jugador (string nombre="Batman", int vida=200, int danio=10): base (nombre, vida, danio)
		{
		}
	}
}