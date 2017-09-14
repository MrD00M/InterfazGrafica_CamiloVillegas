using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spank : MonoBehaviour {

	public UnityEngine.UI.Text spankDisplay;
	public UnityEngine.UI.Text SPC;

	public float spanks = 0.00f;
	public float spankperclick = 10.00f;


	void Update() {
		spankDisplay.text = "B♂ys Spanked: " + spanks;
		SPC.text = "SPC: " + spankperclick + " per click";
	}


	public void Spanked()
	{
		spanks += spankperclick;
	
	}

}
