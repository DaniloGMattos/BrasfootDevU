using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeamController : MonoBehaviour {//Vai controlar os status de todos os times
	static TeamController ThisIsTheOneAndOnlyTeamController;
    public List<GameObject> OnScreenTeams = new List<GameObject>();
	public List<GameObject> LeagueDteams = new List<GameObject>();//lista que recebe todos os times 
	public List<Player> Players = new List<Player>();// Lista que recebe todos os jogadores
    public Creation creation;
    public GameObject myTeam;
    
	public Player playerData;//pra passar os dados de cada jogador
	//para passar os dados para criar um time
	void Awake(){
        ThisIsTheOneAndOnlyTeamController = this; 
		foreach (Transform item in creation.gameObject.transform)
        {
            LeagueDteams.Add(item.gameObject);
        }
        LeagueDteams[0].GetComponent<Team>().teamName = "Tapetinho";
        LeagueDteams[1].GetComponent<Team>().teamName = "Na Hora";
        myTeam = LeagueDteams[0];

	}

	// Use this for initialization
	void Start () {
       
        //If we get here I am the one!
        GameObject.DontDestroyOnLoad(this.gameObject);//Become Immortal
       
        
	
	}
	
	// Update is called once per frame
	void Update () {
        if(SceneManager.GetActiveScene().name.ToString() == "Hub"){
            SetMyTeanInHub();
        }
    }
	public void SelectMyTeam(){
        int index = creation.selectionIndex;
        myTeam = LeagueDteams[index];
	}
    private void SetMyTeanInHub(){
        Vector3 LogoHubPos = new Vector3 (0f,1.2f,0);
        Vector3 LogoHubScale = new Vector3 (0.3060028f,0.3060028f,0.3060028f);
        myTeam.transform.position = LogoHubPos;
        myTeam.transform.localScale = LogoHubScale;
    }
    public static TeamController GetInstance(){
        return ThisIsTheOneAndOnlyTeamController;
    }


	void CreatePlayer(Player data){
		
	}


}
