using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtons : MonoBehaviour {



	public GameObject spc1, spc2, sps1, sps2;



	// Use this for initialization
	void Start () {
		
		spc1.SetActive (false);
		spc2.SetActive (false);
		sps1.SetActive (false);
		sps2.SetActive (false);
	}
		
	// Update is called once per frame
	void Update () {
		
	}


	public void ActivateButtons(){
		spc1.SetActive (true);
		spc2.SetActive (true);
		sps1.SetActive (true);
		sps2.SetActive (true);

	}
}
