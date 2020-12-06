using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMode : MonoBehaviour {
	//rezhim igry

	public Transform cameraV;
	public Transform stolV;
	public Transform peopV;
	public Transform winV;
	public Transform camPos;
	public bool onChem;
	public bool startQ;
	public int nextLVL;

	public bool vsyo;
	void Start () {
		onChem = false;
		camPos = peopV;
	}
	
	// Update is called once per frame
	void Update () {
		cameraV.position = Vector3.Lerp(cameraV.position, camPos.position, Time.deltaTime*5);
		if(Input.GetKeyDown(KeyCode.Q))
		{
			//onChem = !onChem;
			Qgo();
		}
		if(onChem==false)
		{
			camPos = peopV;
		}
		if(onChem==true)
		{
			camPos = stolV;
		}
		if(camPos==winV)
		{
			Win();
		}
		if(vsyo==true)
		{
			Vsyoo();
		}
	}
	public void Vsyoo()
	{
		GameObject.Find("SamChemodan").GetComponent<samChemodan>().pobeda=true;
	}
	public void Qgo()
	{
		onChem=true; //чтобы только на стол накатывать
		startQ=true; //сигнал генератору вещей
		GameObject.Find("Canvas").GetComponent<CanvasControl>().buttPers.SetActive(false);
		GameObject.Find("Canvas").GetComponent<CanvasControl>().buttQ.SetActive(false);
		GameObject.Find("Canvas").GetComponent<CanvasControl>().buttNeProv.SetActive(true);
	}
	public void Win()
	{
		Application.LoadLevel(nextLVL);
	}

	public void Exit()
	{
		Application.Quit();
	}

	public void Restart()
	{
		Application.LoadLevel(nextLVL-1);
	}
}
