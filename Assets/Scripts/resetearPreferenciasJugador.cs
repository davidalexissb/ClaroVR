using UnityEngine;
using System.Collections;

public class resetearPreferenciasJugador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Constantes.raceFinished=false;
		Constantes.totalracersCompleted = 0;
		Constantes.touchFinishLine = false; // SI TOCO AL MENOS UNA VEZ LA BANDERA DE PARTIDA
		Constantes.ultimaVuelta=false; // SI ESTA EN LA ULTIMA VUELTA
		Constantes.carselected=null;
		Constantes.listaPuntajes=null;
		Constantes.listaPuntajesfb=null;
		Constantes.scorelist=null;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
