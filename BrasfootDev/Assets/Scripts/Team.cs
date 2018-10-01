using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Team : MonoBehaviour {
	public Player player;
	public enum League{A,B,C,D};//LIMITA O MAXIMO DE STATS QUE UM TIME PODE TER
	public League league;
	public string teamName;
	public float power;//DETERMINA A CHANCE DE FAZER GOOLS
	public float defence;//DETERMINA A CHANCE DE NAO TOMAR GOOLS
	public float crowd; //BUFA OS STATUS DE DEFESA E POWER
	// Use this for initialization
	void Start () {
		power = Random.Range(0f,100f);
		defence = Random.Range(0f,100f);
		crowd = 100f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void CheckStats(){
		
	}
}
