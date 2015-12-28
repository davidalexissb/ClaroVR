using UnityEngine;
using System.Collections;

public class Constantes : MonoBehaviour {
	public static bool raceFinished=false;
	public static int totalracersCompleted = 0;
	public static int totalRacers = 5;

	//PARA CONTROLAR LAS BANDERAS 
	public static bool touchFinishLine = false; // SI TOCO AL MENOS UNA VEZ LA BANDERA DE PARTIDA
	public static bool ultimaVuelta=false; // SI ESTA EN LA ULTIMA VUELTA
	//=============================// 


	public static string carselected;
	public static ArrayList listaPuntajes;
    public static ArrayList listaPuntajesfb;
    public static ArrayList scorelist;

    public void setCarSelected(string selection){
		carselected = selection;
	}
}
//test github
