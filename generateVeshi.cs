using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateVeshi : MonoBehaviour {

	public persChange persChange;

	/*public GameObject[] norm;
	public GameObject[] kitaec;
	public GameObject[] negor;
	public GameObject[] franc;

	public Transform togka1;
	public Transform togka2;
	public Transform togka3;*/ //наборы на случайную генерацию

	private bool starteng;
	private int srateng;

	//контролируеи==мая генреаия
	public GameObject normal;
	public GameObject negro;
	public GameObject kitai;
	public GameObject franc;

	public persChange persPosit;
	public int chel;

	void Update () {
		/*if(GetComponent<gameMode>().startQ==true)
		{
			srateng=1;;
		}
		int chel = persChange.persPos.gameObject.GetComponent<Ischezka>().chelID;
		if(Input.GetMouseButtonDown(1))
		{
			if(chel==0)
			{
				Instantiate(norm[Random.Range(0, norm.Length)], togka1.position, togka1.rotation);
				Instantiate(norm[Random.Range(0, norm.Length)], togka2.position, togka1.rotation);
				Instantiate(norm[Random.Range(0, norm.Length)], togka3.position, togka1.rotation);
			}
			if(chel==1)
			{
				Instantiate(kitaec[Random.Range(0, norm.Length)], togka1.position, togka1.rotation);
				Instantiate(kitaec[Random.Range(0, norm.Length)], togka2.position, togka1.rotation);
				Instantiate(kitaec[Random.Range(0, norm.Length)], togka3.position, togka1.rotation);
			}
			srateng=2;
		}*/ //на случайную генерацию
		chel=persPosit.curPers;
		if(persPosit.curPers==0)
		{
			normal.SetActive(true);
			negro.SetActive(false);
			kitai.SetActive(false);
			franc.SetActive(false);
		}
		if(persPosit.curPers==1)
		{
			normal.SetActive(false);
			negro.SetActive(false);
			kitai.SetActive(true);
			franc.SetActive(false);
		}
		if(persPosit.curPers==2)
		{
			normal.SetActive(false);
			negro.SetActive(true);
			kitai.SetActive(false);
			franc.SetActive(false);
		}
		if(persPosit.curPers==3)
		{
			normal.SetActive(false);
			negro.SetActive(false);
			kitai.SetActive(false);
			franc.SetActive(true);
		}
	}
}
