using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPCManager : MonoBehaviour {

	public Spank spank;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int level = 0;
	public int level2 = 0;
	public float spankPower;
	public string itemName;
	public string itemDesc;
	private float _newCost, _newPower;

	private UnityEngine.UI.Button Getspc;

	void Start() {
		
		Getspc = this.GetComponent<UnityEngine.UI.Button> ();
		Getspc.interactable = false;
		itemInfo.text = itemName + "\nLevel: " + level + "\n" + itemDesc + "\nCost: " + cost + "\nSpankPower: +" + spankPower + " per click";

	}
	void Update () {

		if (this.gameObject.name == "SPC1") {
			if (spank.spanks <= cost) {
				Getspc.interactable = false;
			} else {
				Getspc.interactable = true;
			}
		}
	}
	public void SPCUpgrade() {
		if (spank.spanks >= cost) {
			spank.spanks -= cost;
			level += 1;
			spank.spankperclick += spankPower;
			cost = Mathf.Round (cost * 2.15f);
			spankPower = Mathf.Round (spankPower * 1.75f);
			_newCost = Mathf.Pow (cost, _newCost = cost);
			_newPower = Mathf.Pow (spankPower, _newPower = spankPower);
			itemInfo.text = itemName + "\nLevel: " + level + "\n" + itemDesc + "\nCost: " + cost + "\nSpankPower: +" + spankPower + " per click";
		}
	}

	public void SPCUpgrade2() {
		if (spank.spanks >= cost) {
			spank.spanks -= cost;
			level2 += 1;
			spank.spankperclick += spankPower;
			cost = Mathf.Round (cost * 2.15f);
			spankPower = Mathf.Round (spankPower * 1.75f);
			_newCost = Mathf.Pow (cost, _newCost = cost);
			_newPower = Mathf.Pow (spankPower, _newPower = spankPower);
			itemInfo.text = itemName + "\nLevel: " + level2 + "\n" + itemDesc + "\nCost: " + cost + "\nSpankPower: +" + spankPower + " per click";
		}
	}
		
}
