using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInterface : MonoBehaviour {

	public static DebugInterface current;

	void Awake(){
		current = this;
	}

	public Text DebugTestObj;

	public static void DebugMsg(string msg){
		if (current.DebugTestObj == null)
			return;
		current.DebugTestObj.text += "\n" + msg;
	}

	public void SliderValueShow(float src){
		if (current.DebugTestObj == null)
			return;
		current.DebugTestObj.text += "\n" + "Setting Speed To : " + src.ToString("F2") ;
	}
}
