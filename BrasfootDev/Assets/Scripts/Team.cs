using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Team : MonoBehaviour {
	public Player player;
	public enum League{A,B,C,D};
	public League league;
	public string teamName;
	public float power;
	public float defence;
	public float crowd;
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
