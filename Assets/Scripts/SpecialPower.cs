using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPower : MonoBehaviour {

	public UnityEngine.UI.Image fillImg;
	public bool activated = false;
	public float timeAmt = 10;
	public float time;
	public SPSManager checkMultiplier1, checkMultiplier2;

	private UnityEngine.UI.Button Getsp;

	void Start () {

		Getsp = this.GetComponent<UnityEngine.UI.Button> ();
		time = timeAmt;
	}
		
	void Update() {

		if (activated == true && time > 0) {
			time -= Time.deltaTime;
			fillImg.fillAmount = time / timeAmt;
			Getsp.interactable = false;



		} else if (time < 0)  {
			activated = false;
			time = 10;
			fillImg.fillAmount = time;
			Getsp.interactable = true;
			checkMultiplier1.multiplier -= 2;
			checkMultiplier2.multiplier -= 2;

		}


		/*if (time > 0) {
			time -= Time.deltaTime;
			fillImg.fillAmount = time / timeAmt;*/
	}

	// Update is called once per frame
	public void Activate () {
		activated = true;
		checkMultiplier1.multiplier += 2;
		checkMultiplier2.multiplier += 2;
	
		}
}
