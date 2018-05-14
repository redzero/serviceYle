using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTitles : MonoBehaviour {

	public Text[] Text ;
	public string title;
	public string duration;
	public string type;
	public bool flag;

	// Use this for initialization
	void Start () {
		Text = GetComponentsInChildren<Text> ();
		Text [0].text = title;
	}

	public void onClick() //function button click
	{
		
		if (!flag) {
			Text [1].text = type;
			Text [2].text = duration;
			flag = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
