using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemMode : MonoBehaviour {


	public persChange persChange;
	public GameObject[] chemodanes;
	public Transform chemPos;

	void Start()
	{
		Instantiate(chemodanes[Random.Range(0, chemodanes.Length-1)], chemPos.position, chemPos.rotation);
	}
	void Update () {
		if(persChange.mojnoVybirat==true)
		{
			if(Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D))
			{
				InstChem();
			}
		}
	}

	public void InstChem()
	{
		Instantiate(chemodanes[persChange.persPos.gameObject.GetComponent<Ischezka>().chelID], chemPos.position, chemPos.rotation);
		//Destroy(GameObject.FindGameObjectWithTag("bort"));
	}
}
