using System;
using Gtk;

namespace Juegaso
{
	public class Inicio
	{
		public Inicio ()
		{
		}

		Window ventana;
		Interface OtraVentana = new Interface ();

		public void inicio ()
		{
			Application.Init ();
			ventana = new Window ("Juego");

			Label nombreJuego = new Label ();
			nombreJuego.Text = "Juego de Batman";

			Button entrar = new Button ("Entrar");
			entrar.Clicked += ventanaJuego;
			Button btnSalir = new Button ("Salir");
			btnSalir.Clicked += salir;

			Image imagenFondo = new Image ("fondo.jpg");

			Fixed capaFix = new Fixed ();
			capaFix.Put (nombreJuego, 150, 10);
			capaFix.Put (imagenFondo, 5, 30);
			capaFix.Put (entrar, 180, 90);
			capaFix.Put (btnSalir, 300, 200);

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

		public void ventanaJuego (object sender, EventArgs args)
		{
			ventana.HideAll ();
			OtraVentana.graficos ();
		}
	}
}