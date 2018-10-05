// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TeamController : MonoBehaviour {//Vai controlar os status de todos os times
// 	public List<GameObject> OnScreenTeams = new List<GameObject>();
// 	public List<Team> LeagueDteams = new List<Team>();//lista que recebe todos os times 
// 	public List<Player> Players = new List<Player>();// Lista que recebe todos os jogadores
// 	public Player playerData;//pra passar os dados de cada jogador
// 	//para passar os dados para criar um time
// 	void Awake(){
// 		OnScreenTeams.Add(GameObject.FindWithTag("MyTeam"));
// 		OnScreenTeams.Add(GameObject.FindWithTag("OtherTeam"));
// 		OnScreenTeams[0].AddComponent<Team>();
// 		OnScreenTeams[1].AddComponent<Team>();

// 	}

// 	// Use this for initialization
// 	void Start () {

// 		foreach (GameObject item in OnScreenTeams)
// 		{
// 			for (int i = 0; i < 5; i++)//crio todos os jogadores
// 			{
// 				item.GetComponent<Team>().player[i].stregth = ;
// 				item.GetComponent<Team>().player[i].talent =  Random.Range(30f,100f);
// 			}
// 		}
		
		
		
// 		for (int i = 0; i < OnScreenTeams.Count; i++)
// 		{
// 			CreateTeam(OnScreenTeams[i].GetComponent<Team>());
// 		}

// 		LeagueDteams[0].teamName = "Na Hora";
// 		LeagueDteams[1].teamName = "Tapetinho";
		
// 	}
	
// 	// Update is called once per frame
// 	void Update () {
		
// 	}
// 	void CreateTeam(Team data){

// 		data.defence = PlayerStregthSum(data.player)/5;
// 		data.crowd = Random.Range(30f,100f);
// 		data.power = PlayerTalentSum(data.player)/5;
// 		data.league = Team.League.D;
// 		LeagueDteams.Add(data);

// 	}


// 	void CreatePlayer(Player data){
// 		data.talent = Random.Range(30f,100f); 
// 		data.stregth = Random.Range(30f,100f);
// 		Players.Add(data);
// 	}


// }
