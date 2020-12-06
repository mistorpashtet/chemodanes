using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persChange : MonoBehaviour {
	//vybor cheloveka

	public GameObject[] personal;
	public GameObject persPos;
	public int curPers;
	public bool mojnoVybirat;
	public GameObject gameMode;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mojnoVybirat = !gameMode.GetComponent<gameMode>().onChem;

		if(mojnoVybirat==true)
		{
			/*if(Input.GetKeyDown(KeyCode.A))
			{
				curPers --;
				persPos = Instantiate(personal[curPers], transform.position, transform.rotation);
			}*/ // чёт влево криво работает, пока так
			if(Input.GetKeyDown(KeyCode.D))
			{
				ChengePers();
			}
		}

		if(persPos==null)
		{
			persPos = Instantiate(personal[0], transform.position, transform.rotation);
		}

		if(curPers>personal.Length-1)
		{
			curPers=0;
		}
		if(curPers<0)
		{
			curPers=personal.Length-1;
		}
	}

	public void ChengePers()
	{
		curPers ++;
		persPos = Instantiate(personal[curPers], transform.position, transform.rotation);
		Destroy(GameObject.FindGameObjectWithTag("lico"));
	}
}
