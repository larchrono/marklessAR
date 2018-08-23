using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDynamicSetting : MonoBehaviour {

	Camera cam;

	void Awake(){
		cam = GetComponent<Camera>();
	}

	// Use this for initialization
	void Start () {
		

		if (!PlayerPrefs.HasKey ("C2Y")) {

			PlayerPrefs.SetFloat ("C2Y", cam.transform.localPosition.y);
			PlayerPrefs.SetFloat ("C2Z", cam.transform.localPosition.z);
			PlayerPrefs.SetFloat ("C2Rx", cam.transform.localRotation.eulerAngles.x);
			PlayerPrefs.SetFloat ("C2Fov", cam.fieldOfView);
		}
	}

	public void SliderY(float src){
		Vector3 ov = cam.transform.localPosition;
		cam.transform.localPosition = new Vector3 (ov.x, src, ov.z);
		PlayerPrefs.SetFloat ("C2Y", src);
	}

	public void SliderZ(float src){
		Vector3 ov = cam.transform.localPosition;
		cam.transform.localPosition = new Vector3 (ov.x, ov.y, src);
		PlayerPrefs.SetFloat ("C2Z", src);
	}

	public void SliderRx(float src){
		Vector3 ov = cam.transform.localRotation.eulerAngles;
		cam.transform.localRotation = Quaternion.Euler (new Vector3 (src, ov.y, ov.z));
		PlayerPrefs.SetFloat ("C2Rx", src);
	}

	public void SliderFoV(float src){
		cam.fieldOfView = src;
		PlayerPrefs.SetFloat ("C2Fov", src);
	}

	public void ShowAllValue(){
		string msg = "y:" + cam.transform.localPosition.y + " , z:" + cam.transform.localPosition.z + " , Rx:" + cam.transform.localRotation.eulerAngles.x +
		             " , FoV:" + cam.fieldOfView;
		DebugInterface.DebugMsg (msg);
	}
}
