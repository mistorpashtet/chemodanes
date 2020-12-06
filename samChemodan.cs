using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class samChemodan : MonoBehaviour {

	public List<GameObject> GoVtrige = new List<GameObject>();
	public GameObject[] veshi;
	public int vVnutri;
	public bool vseMolodcy;
	public bool vseVsbore; //-proverka
	public bool pobeda;
	public GameObject konfetti;
	public int nextlvl;
	// Use this for initialization
	public GameObject kryshka;
	public Transform open;
	public Transform close;

	public Texture2D shek;
	public Texture2D next;
	void Start()
	{
		kryshka.transform.position = open.position;
		nextlvl= GameObject.Find("GameMode").GetComponent<gameMode>().nextLVL;
		List<GameObject> veshichki = new List<GameObject>(veshi.Length);
	}
	// Update is called once per frame
	void Update () {
		veshi = GameObject.FindGameObjectsWithTag("vesh");

		if(veshi.Length==vVnutri)
		{
			Debug.Log("xorosho");
			vseVsbore=true;
		}
		else{ vseVsbore=false;}

		bool okda = veshi.All(veshi => veshi.gameObject.GetComponent<veshCollider>().stayHere);
		if(okda==true)
		{
			vseMolodcy=true;
		}
		else{vseMolodcy=false;}
		//GetComponent<veshCollider>().stayHere; - kriteriy

		if(vseVsbore==true&&vseMolodcy==true)
		{
			GameObject.Find("Canvas").GetComponent<CanvasControl>().buttProv.SetActive(true);
			GameObject.Find("Canvas").GetComponent<CanvasControl>().buttNeProv.SetActive(false);
			if(Input.GetKeyDown(KeyCode.E))
			{
				GameObject.Find("GameMode").GetComponent<gameMode>().vsyo=true;
				//PredPobeda();
			}
		}
		else{GameObject.Find("Canvas").GetComponent<CanvasControl>().buttProv.SetActive(false);}

		if(pobeda==true)
		{
			GameObject.Find("Canvas").GetComponent<CanvasControl>().buttProv.SetActive(false);
			GameObject.Find("Canvas").GetComponent<CanvasControl>().buttPobeda.SetActive(true);
			GameObject.Find("Chemodanishe").GetComponent<igraSchemodnom>().stayHer=false;
			konfetti.SetActive(true);
			kryshka.transform.position = Vector3.MoveTowards(open.position, close.position, 10);
			if(Input.GetKeyDown(KeyCode.N))
			{
				Application.LoadLevel(nextlvl);
			}
		}

	}

	void OnTriggerEnter(Collider vsh)
	{
		if(vsh.gameObject.tag=="vesh")
		{
			vVnutri++;
			GoVtrige.Add(vsh.gameObject);
		}
	}
	void OnTriggerExit(Collider vsh)
	{
		if(vsh.gameObject.tag=="vesh")
		{
			GoVtrige.Remove(vsh.gameObject);
			vVnutri-=1;
		}
	}

	public void PredPobeda()
	{
		pobeda=true;
		GameObject.Find("GameMode").GetComponent<gameMode>().camPos=GameObject.Find("GameMode").GetComponent<gameMode>().winV;
	}

	/* void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 250, 50), "е - чтобы проверить");
		if(pobeda==true)
		{
			GUI.Label(new Rect(10, 70, 250, 50), "т - продолжить");
		}
	} */
}
