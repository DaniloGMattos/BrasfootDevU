using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {//Vai controlar os stats de todos os jogadores
	public List<Player> OnScreenMyPlayers = new List<Player>();
	public List<Player> OnScreenOtherPlayers = new List<Player>();
	public List<string> firstnames;
	public List<string> surnames;
	public GameObject myTeam;
	public GameObject otherTeam;


	// Use this for initialization
	void Start (){

		// FOR THE NAME GENERATOR ...
		TextAsset nameText = Resources.Load<TextAsset>("Names");

		string [] lines = nameText.text.Split("\n"[0]);

		bool addingFirstnames = true;

		for(int i = 0; i <lines.Length; i ++){
			
			if(lines[i] == "FirstNames:")
			{
				addingFirstnames = true;
				Debug.Log("adding first names");
				continue;
			}

			if(lines[i] == "SurNames:")
			{
				addingFirstnames = false;
				Debug.Log("adding surnames");
				continue;
			}

			if(lines[i] != ""){
				if(addingFirstnames){
					firstnames.Add (lines[i]);
				}
				else{
					surnames.Add(lines[i]);
				}

			}


		}
		//GETTING ONSCREEN TEAMS PLAYERS

		myTeam = GameObject.FindGameObjectWithTag("MyTeam");
		otherTeam = GameObject.FindGameObjectWithTag("OtherTeam");

		foreach (Player player in myTeam.GetComponent<Team>().Players)
		{
			player.playerName = generateName();
			OnScreenMyPlayers.Add(player);	
		}
		foreach (Player player in otherTeam.GetComponent<Team>().Players)
		{
			player.playerName = generateName();
			OnScreenMyPlayers.Add(player);	
		}
	}
	string generateName(){
		string firstname;
		string surname;

		firstname = firstnames[Random.Range(0,firstnames.Count)];
		surname = surnames[Random.Range(0,surnames.Count)];

		string returnName = firstname + " " + surname;

		return returnName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
