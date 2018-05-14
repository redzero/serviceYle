/*

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSearch : MonoBehaviour {

	// Use this for initialization
	public Transform inputSearch;
	public string stringSearch="";
	private Text textSearch;
	public InputField iField;
	public Text msjText;
	public ServiceApi serviceApi;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Onclick(){

		if (iField.text != "") {

			stringSearch = iField.text;
//			Debug.Log (stringSearch);
			serviceApi.LoadAPI (stringSearch);
			msjText.text = "Searching...";

		} else {
			msjText.text = "Enter a program";
		}
	
	}


}
