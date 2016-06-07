using System;
using Gtk;
namespace Juegaso
{
	public class VentanaFinal2
	{
		public VentanaFinal2 ()
		{
		}
		Window ventana;

		public void final2 ()
		{
			Application.Init ();
			ventana = new Window ("Juego");
			
			Label nombreJuego = new Label ();
			nombreJuego.Text = "Lo haz derrotado... GANASTE!!!";
			
			Button btnSalir = new Button ("Salir");
			btnSalir.Clicked += salir;
			
			Image imagenFondo = new Image ("bat_win.gif");
			
			Fixed capaFix = new Fixed ();
			capaFix.Put (nombreJuego, 150, 10);
			capaFix.Put (imagenFondo, 5, 30);
			capaFix.Put (btnSalir, 350, 310);

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