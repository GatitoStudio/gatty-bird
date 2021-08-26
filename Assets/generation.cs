using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class generation : MonoBehaviour {
	public GameObject obstacle;
	GameObject lobstacle;

	// Use this for initialization
	void Start () {


		obstacle = Resources.Load ("obstacle") as GameObject; 
		InvokeRepeating ("obsctacle", 1f,1.5f);
	}
	void obsctacle()
	{
		float y = Random.Range (-0.5f, 1f);
		lobstacle = Instantiate (obstacle) as GameObject;
		lobstacle.transform.position = lobstacle.transform.position + new Vector3 (0, y, 0);
	}
	// Update is called once per frame

}
 