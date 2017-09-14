using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanksPerSec : MonoBehaviour {

	public UnityEngine.UI.Text SPS;

	public Spank spank;

	public SPSManager[] items;

	void Start() {
		StartCoroutine (AutoTick());
	}

	void Update() {
		SPS.text = "SPS: " + GetSpanksPerSec () + "/s";
	}

	public float GetSpanksPerSec() {
		float tick = 1.00f;
		foreach (SPSManager item in items) {
			tick += item.level * item.tickValue * item.multiplier;
			tick += item.level2 * item.tickValue * item.multiplier;
		}
		return tick;
	}

	public void AutoSpanksPerSec() {
		spank.spanks += GetSpanksPerSec ();
	}


	IEnumerator AutoTick() {
		while (true) {
			AutoSpanksPerSec ();
			yield return new WaitForSeconds (1);
		}
	}
		
}