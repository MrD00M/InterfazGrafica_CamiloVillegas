using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPSManager : MonoBehaviour {

	public Spank spank;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int level = 0;
	public int level2 = 0;
	public int tickValue;
	public int multiplier = 1;
	public string itemName;
	public string itemDesc;
	private float _newCost;

	private UnityEngine.UI.Button Getsps;


	void Start() {
		Getsps = this.GetComponent<UnityEngine.UI.Button> ();
		Getsps.interactable = false;

		itemInfo.text = itemName + "\nLevel: " + level + "\n" + itemDesc + "\nCost: " + cost + "\nSpankPower: +" + tickValue + "/s";

	}
	void Update () {
		
		if (this.gameObject.name == "SPS1") {
			if (spank.spanks <= cost) {
				Getsps.interactable = false;
			} else {
				Getsps.interactable = true;
			}
		} 
	}

	public void SPSUpgrade() {
		if (spank.spanks >= cost) {
			spank.spanks -= cost;
			level += 1;
			cost = Mathf.Round (cost * 1.75f);
			_newCost = Mathf.Pow (cost, _newCost = cost);
			itemInfo.text = itemName + "\nLevel: " + level + "\n" + itemDesc + "\nCost: " + cost + "\nSpankPower: +" + tickValue + "/s";
			//_newPower = Mathf.Pow (SpanksPerSecond, _newPower = SpanksPerSecond);
		}
	}

	public void SPSUpgrade2() {
		if (spank.spanks >= cost)
		 {
			spank.spanks -= cost;
			level2 += 1;
			cost = Mathf.Round (cost * 1.75f);
			_newCost = Mathf.Pow (cost, _newCost = cost);
			itemInfo.text = itemName + "\nLevel: " + level2 + "\n" + itemDesc + "\nCost: " + cost + "\nSpankPower: +" + tickValue + "/s";
		}
	}
}
