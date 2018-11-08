using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour {

	public void playgame() {
		
		SceneManager.LoadScene("terrain");
	}
	public void playgameold() {
		
		SceneManager.LoadScene("TextTrack");
	}
	public void quitbutton() {
		Debug.Log("quit");
		Application.Quit();
	}
}
