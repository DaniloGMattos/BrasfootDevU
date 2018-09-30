using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour {
	public Player player;
	private enum League{A,B,C,D};
	private League league;
	private string teamName;
	private float power;
	private float defence;
	private float crowd;
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
