using UnityEngine;
using System.Collections;

public class mouvementsol : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 8);
		transform.Translate(new Vector3(5,0,0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
