using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ischezka : MonoBehaviour {

	public int chelID;
	public GameObject gameMode;
	// Use this for initialization
	void Start () {
		gameMode = GameObject.Find("GameMode");
	}
	
	// Update is called once per frame
	void Update () {
		if(gameMode.GetComponent<gameMode>().onChem==false)
		{
			if(Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D))
			{
				Ischezaka();
			}
		}
	}

	public void Ischezaka()
	{
		Destroy(gameObject);
	}
}
