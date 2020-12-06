using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igraSchemodnom : MonoBehaviour {

	public GameObject predmet;
	public string nameP;
	public float distinkt;
	private bool vzyat;
	public bool stayHer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(stayHer==true)
		{
			if(Input.GetMouseButtonDown(0))
			{
				vzyat=!vzyat;
				RaycastHit hitPoint;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if(Physics.Raycast(ray, out hitPoint))
				{
					predmet = hitPoint.collider.gameObject;
					nameP = predmet.name;
				}
			}
			if(predmet.tag=="vesh")
			{
				if(vzyat==true)
				{
					OnMouseDrag();
				}
			}
		}
		
	}
	void OnMouseDrag()
	{
		Vector3 myshka = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distinkt);
		Vector3 mpoint = Camera.main.ScreenToWorldPoint(myshka);
		predmet.transform.position = new Vector3(mpoint.x, 0.5f, mpoint.z);
	}

	void OnGUI()
	{
		if(predmet.tag=="vesh")
		{
			if(vzyat==true)
			{
				GUI.Label(new Rect(100,200, 250,50), nameP);
			}
		}
	}


}
