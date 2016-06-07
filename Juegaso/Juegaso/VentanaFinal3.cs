using System;
using Gtk;
namespace Juegaso
{
	public class VentanaFinal3
	{
		public VentanaFinal3 ()
		{
		}
		Window ventana;
		
		public void final3 ()
		{
			Application.Init ();
			ventana = new Window ("Juego");
			
			Label nombreJuego = new Label ();
			nombreJuego.Text = "Mutuamente se pegaron al final... EMPATE";
			
			Button btnSalir = new Button ("Salir");
			btnSalir.Clicked += salir;
			
			Image imagenFondo = new Image ("draw.gif");
			
			Fixed capaFix = new Fixed ();
			capaFix.Put (nombreJuego, 10, 10);
			capaFix.Put (imagenFondo, 5, 30);
			capaFix.Put (btnSalir, 250, 10);
			
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