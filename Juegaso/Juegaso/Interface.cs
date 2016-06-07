using System;
using Gtk;
using System.Timers;

namespace Juegaso
{
	public class Interface
	{
		Window ventana;
		Label peleaJugador;
		Label peleaJugador2;
		Label peleaEnemigo;
		Label peleaEnemigo2;
		Label estadoEnemigo;
		Label estadoJugador;
		Label nomJugador;
		Label uso1;
		Label uso2;
		Label uso3;
		Entry cambiar;
		Jugador player1 = new Jugador ();
		Enemigo cpu = new Enemigo ();
		Random rand = new Random ();
		Timer tiempo;
		Button btnAtack1;
	    Button btnAtack2;
		Button btnAtack3;
		string mov;
		int Atack1 = 20;
		int Atack2 = 10;
		int Atack3 = 5;
		int contPistola = 25;
		int contCuchillo = 15;
		int contGranada = 10;

		public Interface ()
		{
		}

		public void graficos ()
		{
			Application.Init();
			ventana = new Window ("Juego");

			Label nomGame = new Label ();
			nomGame.Text = "JUEGO DE PELEAS";
			Label movimientos = new Label ();
			movimientos.Text = "Movimientos";
			uso1 = new Label ();
			uso1.Text = Atack1.ToString();
			uso2 = new Label ();
			uso2.Text = Atack2.ToString();
			uso3 = new Label ();
			uso3.Text = Atack3.ToString();
			nomJugador = new Label ();
			nomJugador.Text = player1.Nombre;
			estadoJugador = new Label ();
			estadoJugador.Text = "" + player1.Vida;
			peleaJugador = new Label ();
			peleaJugador.Text = "";
			peleaJugador2 = new Label ();
			peleaJugador2.Text = "";
			Label nomEnemigo = new Label ();
			nomEnemigo.Text = cpu.Nombre;
			estadoEnemigo = new Label ();
			estadoEnemigo.Text= "" + cpu.Vida;
			peleaEnemigo = new Label ();
			peleaEnemigo.Text = "";
			peleaEnemigo2 = new Label ();
			peleaEnemigo2.Text = "";
			Label option = new Label ();

			Button btnSalir = new Button ("Salir");
			btnSalir.Clicked += salirJuego;
			btnAtack1 = new Button ("Kung Fu");
			btnAtack1.Clicked += ataque1;
			btnAtack2 = new Button ("Batarang");
			btnAtack2.Clicked += ataque2;
			btnAtack3 = new Button ("Llamar Batimovil");
			btnAtack3.Clicked += ataque3;
			Button btnChange = new Button ("Cambiar");
			btnChange.Clicked += cambiarNombre;

			tiempo = new Timer (2000);
			tiempo.Elapsed += new ElapsedEventHandler (tiempoJuego);

			cambiar = new Entry ("Nuevo Nombre");

			Image jugador = new Image ("bat.gif");
			Image cpuImagen = new Image ("joke.gif");

			Fixed capaFix = new Fixed ();
			capaFix.Put (jugador, 40, 150);
			capaFix.Put (cpuImagen, 210, 150);
			capaFix.Put (nomGame, 400, 5);
			capaFix.Put (option , 640, 40);
			capaFix.Put (nomJugador, 40, 40);
			capaFix.Put (estadoJugador, 40, 70);
			capaFix.Put (peleaJugador, 40, 100);
			capaFix.Put (peleaJugador2, 40, 120);
			capaFix.Put (nomEnemigo, 210, 40);
			capaFix.Put (estadoEnemigo, 210, 70);
			capaFix.Put (peleaEnemigo, 210, 100);
			capaFix.Put (peleaEnemigo2, 210, 120);
			capaFix.Put (btnSalir, 710, 200);
			capaFix.Put (btnAtack1, 420, 60);
			capaFix.Put (btnAtack2, 420, 120);
			capaFix.Put (btnAtack3, 400, 180);
			capaFix.Put (btnChange, 650, 130);
			capaFix.Put (cambiar, 600, 100);
			capaFix.Put (uso1, 500, 70);
			capaFix.Put (uso2, 500, 130);
			capaFix.Put (uso3, 510, 190);
			capaFix.Put (movimientos, 408, 40);

			ventana.SetPosition (WindowPosition.Center);
			ventana.Add (capaFix);
			ventana.Resize (900, 350);
			ventana.ShowAll ();

			Application.Run ();
		}

		public void salirJuego (object sender, EventArgs args)
		{
			Application.Quit ();
		}

		public void cambiarNombre (object sender, EventArgs args)
		{
			nomJugador.Text = cambiar.Text;
		}

		public void ataque1 (object sender, EventArgs args)
		{
			if(Atack1 > 0){
				int azar = rand.Next (1, 11);
				peleaJugador.Text = "Usas tus artes marciales!";
				peleaEnemigo.Text = "Espera tu ataque...";
				btnAtack1.Hide ();
				btnAtack2.Hide ();
				btnAtack3.Hide ();
				peleaJugador2.Hide ();
				peleaEnemigo2.Hide ();
				estadoEnemigo.Hide ();
				estadoJugador.Hide ();
				int damage = player1.Danio;
				Atack1 = Atack1 - 1;
				uso1.Text = Atack1.ToString ();
				tiempo.Enabled = true;
				if(azar >= 5){
					peleaJugador2.Text = "Le diste!";
					ataqueJugador (damage);
					ataquesCpu ();
					accionEnemigo ();
				}
				else{
					peleaJugador2.Text = "Fallaste!";
					ataquesCpu ();
					accionEnemigo ();
				}
			}
			else{
				uso1.Text="Ataque Agotado";
				btnAtack1.Hide ();
			}
		}

		public void ataque2 (object sender, EventArgs args)
		{
			if(Atack2 > 0){
				int azar = rand.Next (1, 11);
				peleaJugador.Text = "Lanzaste Batarang!";
				peleaEnemigo.Text = "Espera tu ataque...";
				btnAtack1.Hide ();
				btnAtack2.Hide ();
				btnAtack3.Hide ();
				peleaJugador2.Hide ();
				peleaEnemigo2.Hide ();
				estadoEnemigo.Hide ();
				estadoJugador.Hide ();
				int damage = player1.Danio + 5;
				Atack2 = Atack2 - 1;
				uso2.Text = Atack2.ToString ();
				tiempo.Enabled = true;
			if(azar <= 4){
				peleaJugador2.Text = "Le diste!";
				ataqueJugador (damage);
				ataquesCpu ();
				accionEnemigo ();
			}
			else{
				peleaJugador2.Text = "Fallaste!";
				ataquesCpu ();
				accionEnemigo ();
				}
			}
			else{
				uso2.Text="Ataque Agotado";
				btnAtack2.Hide ();
			}
		}

		public void ataque3 (object sender, EventArgs args)
		{
			if (Atack3 > 0){
				int azar = rand.Next (1, 11);
				peleaJugador.Text = "Tratas de atropellarlo!";
				peleaEnemigo.Text = "Espera tu ataque...";
				btnAtack1.Hide ();
				btnAtack2.Hide ();
				btnAtack3.Hide ();
				peleaJugador2.Hide ();
				peleaEnemigo2.Hide ();
				estadoEnemigo.Hide ();
				estadoJugador.Hide ();
				int damage = player1.Danio + 10;
				Atack3 = Atack3 - 1;
				uso3.Text = Atack3.ToString ();
				tiempo.Enabled = true;
			if(azar >= 6){
				peleaJugador2.Text = "Le diste!";
				ataqueJugador (damage);
				ataquesCpu ();
				accionEnemigo ();
			}
			else{
				peleaJugador2.Text = "Fallaste!";
				ataquesCpu ();
				accionEnemigo ();
				}
			}
			else{
				uso3.Text="Ataque Agotado";
				btnAtack3.Hide ();
			}
		}

		public int ataqueJugador (int damage)
		{
			int life = cpu.Vida;
			life = life - damage;
			cpu.Vida = life;
			if (cpu.Vida <= 0) {
				if (player1.Vida <= 0){
					VentanaFinal3 OtraVentana = new VentanaFinal3 ();
					ventana.HideAll ();
					OtraVentana.final3 ();
				}
				else{
					VentanaFinal2 OtraVentana = new VentanaFinal2 ();
					ventana.HideAll ();
					OtraVentana.final2 ();
				}
			} 
			else{
				estadoEnemigo.Text = "" + cpu.Vida;
				estadoEnemigo.Hide ();
			}
			return cpu.Vida;
		}
		
		public void ataquesCpu ()
		{
			if (contPistola > 0 || contCuchillo > 0 || contGranada > 0) {
				int random = rand.Next (1, 11);
				if (random <= 5) {
					peleaEnemigo2.Text = "Te a pegado!";
					int azar = rand.Next (1, 16);
					if (azar < 6) {
						int damage = cpu.Danio;
						ataqueEnemigo (damage);
					} 
					else if (azar < 11) {
						int damage = cpu.Danio + 7;
						ataqueEnemigo (damage);
					} 
					else{
						int damage = cpu.Danio + 12;
						ataqueEnemigo (damage);
						}
				} 
				else{
					peleaEnemigo2.Text = "Fallo!";
					}
			} 
			else {
				peleaEnemigo2.Text = "";
			}
		}
		
		public int ataqueEnemigo (int damage)
		{
			if (contPistola > 0 || contCuchillo > 0 || contGranada > 0) {
				int life = player1.Vida;
				life = life - damage;
				player1.Vida = life;
				if (player1.Vida <= 0) {
					if (cpu.Vida <= 0) {
						VentanaFinal3 OtraVentana = new VentanaFinal3 ();
						ventana.HideAll ();
						OtraVentana.final3 ();
					} 
					else {
						VentaFinal OtraVentana = new VentaFinal ();
						ventana.HideAll ();
						OtraVentana.final ();
					}
				} 
				else {
					estadoJugador.Text = "" + player1.Vida;
					estadoJugador.Hide ();
				}
			}
			return player1.Vida;
		}
		
		public string accionEnemigo ()
		{
			string[] movEnemigo = new string[4];
			int contador = 0;
			int condicion = 0;
			movEnemigo [0] = "Uso Pistola!!";
			movEnemigo [1] = "Lanzó Cuchillo!";
			movEnemigo [2] = "Utilizo Granada!!!!!";
			movEnemigo [3] = "Ya no tiene ataques";
			while (contador == 0) {
				condicion++;
				int azar = rand.Next (0, 3);
				if(azar == 0){
					if(contPistola > 0){
						mov = movEnemigo[azar];
						contPistola --;
						contador ++;
					}
				}
				if(azar == 1){
					if(contCuchillo > 0){
						mov = movEnemigo[azar];
						contCuchillo --;
						contador ++;
					}
				}
				if(azar == 2){
					if(contGranada > 0){
						mov = movEnemigo[azar];
						contGranada --;
						contador ++;
					}
				}
				if(condicion > 5){
					mov = movEnemigo[3];
					contador ++;
				}
			} 
			return mov;
		}

		public void tiempoJuego (object sender, EventArgs args)
		{
			peleaEnemigo.Text = "" + mov;
			btnAtack1.Show ();
			btnAtack2.Show ();
			btnAtack3.Show ();
			estadoJugador.Show ();
			estadoEnemigo.Show ();
			peleaJugador2.Show ();
			peleaEnemigo2.Show ();
			tiempo.Enabled = false;
		}
	}
}