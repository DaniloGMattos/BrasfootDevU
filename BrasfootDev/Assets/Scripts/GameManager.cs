using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class GameManager : MonoBehaviour {
	public Text timer;
	public Text goolsHome;
	public Text goolsOther;
	public Team team_A;
	private int goolsA;
	private int goolsB;
	public Team team_B;
	public Player player;
	public enum TurnState{
		PROCESSING, //O JOGO ESTA ACONTECENDO E O TEMPO CORRENDO
		WAITING,//TECNICO PEDIU TEMPO
		NOTHING,//O USUARIO NAO SELECIONOU NADA
		FINISHED //ACABOU O JOGO
	
	}
	public TurnState currentState;

	//for the ProgressBar
	private float cur_time = 0f;
	private float max_time = 10f;
	private float calc_timeElapsed;
	private int actionTime = 0;
	public Image ProgressBar;
	
	// Use this for initialization
	void Start () {
		team_A.teamName = "Na Hora";
		team_B.teamName = "Tapetinho";
		currentState = TurnState.PROCESSING;
		StartCoroutine("CompareInXSeconds");//Inicializa a função
	}
	IEnumerator CompareInXSeconds(){
		bool isHappening = true;
		int quantasVezes = 0;
		while(isHappening)
		{
			Compare();
			quantasVezes++;
			if(quantasVezes == 3){//limita o numero de vezes que pode acontecer
				isHappening = false;
			}
			yield return new WaitForSeconds(3);
		}
	}
	
	// Update is called once per frame
	void Update () {

		switch(currentState){

			case(TurnState.PROCESSING):
				UpdateProgressBrar();
				RunTimer();
				if(Time.deltaTime <= max_time){
					CompareInXSeconds();
				}
				
			break;
			
			case(TurnState.WAITING):
			break;
			
			case(TurnState.NOTHING):
			break;
			case(TurnState.FINISHED):
				WhoWon();
				currentState = TurnState.NOTHING;
			break;
		}
		
	}
	void Compare(){
		print("comparando...");
		if(team_A.power/team_B.defence >= 1){
			goolsA ++;
			UpdateUI();
			print(team_A.teamName);
		} 
		else if (team_B.power/team_A.defence >= 1){
			goolsB++;
			UpdateUI();
			print(team_B.teamName);
		}
		else{
			print("No Gool");
		}
	}

	void UpdateProgressBrar(){
		
		cur_time = cur_time + Time.deltaTime;
		float calc_timeElapsed = cur_time / max_time;
		ProgressBar.transform.localScale = new Vector3 (Mathf.Clamp(calc_timeElapsed, 0, 1), ProgressBar.transform.localScale.y,ProgressBar.transform.localScale.z); 
		if(cur_time >=max_time){
			currentState = TurnState.FINISHED;
		}

	}
	void UpdateUI(){
		if(goolsA.ToString() != goolsHome.text){
			goolsHome.text = goolsA.ToString();
		}
		if(goolsB.ToString() != goolsOther.text){
			goolsOther.text = goolsB.ToString();
		}
		
	}
	void RunTimer(){
		if(Time.deltaTime < max_time){
			timer.text = (cur_time + Time.deltaTime).ToString("00");	
		}
	}
	void WhoWon(){
		if (goolsA >goolsB){
			print(team_A.teamName + " ganhou!"); 
		}else if( goolsA == goolsB){
			print("Empate!");
		}else{
			print(team_B.teamName + " ganhou!");
		}
	}
}