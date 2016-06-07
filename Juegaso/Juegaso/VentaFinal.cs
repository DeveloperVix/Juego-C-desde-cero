using System;
using Gtk;

namespace Juegaso
{
	public class VentaFinal
	{
		public VentaFinal ()
		{
		}

		Window ventana;

		public void final ()
		{
			Application.Init ();
			ventana = new Window ("Juego");
			
			Label nombreJuego = new Label ();
			nombreJuego.Text = "Guason te pega su mejor ataque... HAZ PERDIDO";

			Button btnSalir = new Button ("Salir");
			btnSalir.Clicked += salir;
			
			Image imagenFondo = new Image ("joke_win.gif");
			
			Fixed capaFix = new Fixed ();
			capaFix.Put (nombreJuego, 150, 10);
			capaFix.Put (imagenFondo, 5, 30);
			capaFix.Put (btnSalir, 450, 10);

			ventana.SetPosition (WindowPosition.Center);
			ventana.Add (capaFix);
			ventana.Resize (200, 170);
			ventana.ShowAll ();
			
			Application.Run ();
		}
		
		public void salir (object sender, EventArgs args)
		{
			Application.Quit ();
		}
	}
}