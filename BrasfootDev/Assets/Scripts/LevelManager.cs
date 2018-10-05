using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel +1 );//posso botar o level index ou uma string, nesse caso estou usando o level index
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
}
