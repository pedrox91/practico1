using UnityEngine;
using System.Collections;

public class Rectangulo : MonoBehaviour { // es la super clase principal en unity

	private int width = 100;
	private int height = 80;

	public void OnGUI(){ // este metodo permite renderizar elementos y la manipulacion de eventos
		Rect rectangulo = new Rect(10,10,this.width,this.height);
		GUI.Button(rectangulo,"Rectangulo"); /*metodo estatico que dibuja un boton, en este caso se pasa como argumento
		un elemento de tipo Rect y un string */
	}
}
