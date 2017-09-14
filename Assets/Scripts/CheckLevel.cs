using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLevel : MonoBehaviour {

	public SPSManager checkSPSlevel;
	public SPCManager checkSPClevel;

	public SPSManager checkSPScost;
	public SPCManager checkSPCcost;

	public Spank spank;

	public UnityEngine.UI.Button SPC2;
	public UnityEngine.UI.Button SPS2;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (checkSPClevel.level >= 10 && spank.spanks >= checkSPCcost.cost) {
			SPC2.interactable = true;
		} else {
			SPC2.interactable = false;
		}

		if (checkSPSlevel.level >= 10 && spank.spanks >= checkSPScost.cost) {
			SPS2.interactable = true;
		} else {
			SPS2.interactable = false;
		}
	}
}
