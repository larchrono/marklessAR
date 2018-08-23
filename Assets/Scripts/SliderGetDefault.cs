using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderGetDefault : MonoBehaviour {

	public string valueKey;
	Slider sld;

	// Use this for initialization
	void Start () {
		sld = GetComponent<Slider> ();
		GetPlayerValue (sld,valueKey);
	}
	
	public void GetPlayerValue(Slider sld,string key){
		float val = PlayerPrefs.GetFloat (key, 0);
		sld.value = val;
	}
}
