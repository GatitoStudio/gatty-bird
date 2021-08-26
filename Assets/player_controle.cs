using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player_controle : MonoBehaviour {
	public Vector2 jumpforce = new Vector2 (0, 500);
	Rigidbody2D player;
	Vector3 birdRotation = Vector3.zero;
	public GameObject jeu;
	GameObject guijeu;
	Text txt;
	int score = 0;
	float RotateUpSpeed = 0.5f;
	float RotateDownSpeed = 0.8f;
	// Use this for initialization
	void Start () { 
		player = GetComponent<Rigidbody2D> ();
		guijeu = GameObject.Find("Score");
		txt = guijeu.GetComponent<Text> ();
		Instantiate (jeu);
		player.AddForce (jumpforce);
	}
	FlappyYAxisTravelState flappyYAxisTravelState;

	enum FlappyYAxisTravelState
	{
		GoingUp, GoingDown
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetMouseButtonDown (0)) {
			player.velocity = Vector2.zero;
			player.AddForce (jumpforce);
		}
		FixFlappyRotation();
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Pipeblank") //pipeblank is an empty gameobject with a collider between the two pipes
		{
			score++;
			txt.text = score.ToString ();
		}
		else if (col.gameObject.tag == "obstacle")
		{
			playerdead ();
		}
	}
	void playerdead ()
	{
		SceneManager.LoadScene (Application.loadedLevel);
	}
	private void FixFlappyRotation()
	{
		if (GetComponent<Rigidbody2D>().velocity.y > 0) flappyYAxisTravelState = FlappyYAxisTravelState.GoingUp;
		else flappyYAxisTravelState = FlappyYAxisTravelState.GoingDown;

		float degreesToAdd = 0;

		switch (flappyYAxisTravelState)
		{
		case FlappyYAxisTravelState.GoingUp:
			degreesToAdd = 6 * RotateUpSpeed;
			break;
		case FlappyYAxisTravelState.GoingDown:
			degreesToAdd = -3 * RotateDownSpeed;
			break;
		default:
			break;
		}
		//solution with negative eulerAngles found here: http://answers.unity3d.com/questions/445191/negative-eular-angles.html

		//clamp the values so that -90<rotation<45 *always*
		birdRotation = new Vector3(0, 0, Mathf.Clamp(birdRotation.z + degreesToAdd, -90, 45));
		transform.eulerAngles = birdRotation;
	}

}
