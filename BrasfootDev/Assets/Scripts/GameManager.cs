using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class GameManager : MonoBehaviour {
	public Team team;
	public Player player;
	public enum TurnState{
		PROCESSING, //O JOGO ESTA ACONTECENDO E O TEMPO CORRENDO
		WAITING,//TECNICO PEDIU TEMPO
		NOTHING,
		FINISHED
		
	}
	//for the ProgressBar
	private float cur_time = 0f;
	private float max_time = 10f;
	private float calc_timeElapsed;
	public Image ProgressBar;
	public TurnState currentState;
	// Use this for initialization
	void Start () {
		currentState = TurnState.PROCESSING;
	}
	
	// Update is called once per frame
	void Update () {

		switch(currentState){

			case(TurnState.PROCESSING):
				UpdateProgressBrar();
			break;
			
			case(TurnState.WAITING):
			break;
			
			case(TurnState.NOTHING):
			break;
			case(TurnState.FINISHED):
			break;
		}
		
	}
	void Compare(){
		
	}

	void UpdateProgressBrar(){
		
		cur_time = cur_time + Time.deltaTime;
		float calc_timeElapsed = cur_time / max_time;
		ProgressBar.transform.localScale = new Vector3 (Mathf.Clamp(calc_timeElapsed, 0, 1), ProgressBar.transform.localScale.y,ProgressBar.transform.localScale.z); 
		if(cur_time >=max_time){
			currentState = TurnState.FINISHED;
		}

	}
}