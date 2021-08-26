using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class commencer : MonoBehaviour {
	public GameObject flappy;
	public GameObject guititre;
	GameObject guijeu;
	Text txt;
	public 	void downbutton_play()
	{
		SceneManager.LoadScene ("flappybirdy");
	}
	// Use this for initialization
	void Start () {
		//menu = Resources.Load ("Canvas") as GameObject;
		//lemenu = Instantiate (menu) as GameObject
		guijeu = GameObject.Find("Score");
		txt = guijeu.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (flappy);
			guititre.SetActive (false);
			txt.text = "0";
			DestroyImmediate (gameObject);
			//DestroyImmediate (lemenu);
		}
	}

}
