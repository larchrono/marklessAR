using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDynamicSetting : MonoBehaviour {

	Camera cam;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();
	}

	public void SliderY(float src){
		Vector3 ov = cam.transform.localPosition;
		cam.transform.localPosition = new Vector3 (ov.x, src, ov.z);
	}

	public void SliderZ(float src){
		Vector3 ov = cam.transform.localPosition;
		cam.transform.localPosition = new Vector3 (ov.x, ov.y, src);
	}

	public void SliderRx(float src){
		Vector3 ov = cam.transform.localRotation.eulerAngles;
		cam.transform.localRotation = Quaternion.Euler (new Vector3 (src, ov.y, ov.z));
	}

	public void SliderFoV(float src){
		cam.fieldOfView = src;
	}

	public void ShowAllValue(){
		string msg = "y:" + cam.transform.localPosition.y + " , z:" + cam.transform.localPosition.z + " , Rx:" + cam.transform.localRotation.eulerAngles.x +
		             " , FoV:" + cam.fieldOfView;
		DebugInterface.DebugMsg (msg);
	}
}
