using UnityEngine;
using System.Collections;

public class generesol : MonoBehaviour {
	public GameObject sol;
	GameObject lesol;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("generesole", 2f, 1.9f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void generesole()
	{
		lesol = Instantiate(sol) as GameObject;
		Destroy (lesol, 13);
	}
}
