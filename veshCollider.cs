using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veshCollider : MonoBehaviour {

	public GameObject ghildr;
	public bool stayHere;

	void Start()
	{
		ghildr = transform.GetChild(0).gameObject;
	}





	void OnTriggerEnter(Collider veshk)
	{
		if(veshk.gameObject.tag=="vesh")
		{
			stayHere = false;
			Debug.Log("ups");
			ghildr.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red); //.color = Color.red;
			GetComponent<MeshRenderer>().enabled=true;
		}
	}

	void OnTriggerStay(Collider veshk)
	{
		if(veshk.gameObject.tag=="vesh")
		{
			stayHere = false;
		}
	}

	void OnTriggerExit(Collider veshk)
	{
		if(veshk.gameObject.tag=="vesh")
		{
			Debug.Log("huh");
			ghildr.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.white);
			GetComponent<MeshRenderer>().enabled=false;
		}
		stayHere = true;
	}
}
