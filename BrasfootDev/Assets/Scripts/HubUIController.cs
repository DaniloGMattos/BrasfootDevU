using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HubUIController : MonoBehaviour {//Vai controlar toda a interface do usuário , principalmente no Hub
	public Text TeamName;
	public Image PowerPB;
	public Image DefencePB;
	public Text CoachName;
	public Text League;
	public Text Money;
	public Text CoachLevel;
	public GameObject myTeam;
	

	// Use this for initialization
	void Start () {
		//nome do time na tela
		myTeam = TeamController.GetInstance().myTeam;
		TeamName.text = myTeam.GetComponent<Team>().teamName;
		//nome do tecnico na tela
		CoachName.text = CoachController.GetInstance().coach.coachName;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
