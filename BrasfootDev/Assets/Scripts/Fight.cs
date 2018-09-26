using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Fight : MonoBehaviour {
	public Team team;
	public Player player;
	public enum TurnState{
		PROCESSING, //O JOGO ESTA ACONTECENDO E O TEMPO CORRENDO
		WAITING,//TECNICO PEDIU TEMPO
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
