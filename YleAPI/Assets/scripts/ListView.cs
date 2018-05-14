
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ListView : MonoBehaviour {

	public bool flag;
	public ServiceApi serviceApi;

	public RectTransform contentRect;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (flag) {
			serviceApi.LoadAPI ("");
			flag = false;
		}
		float contentY = Mathf.Max(0, contentRect.offsetMax.y);
	
//				Debug.Log (contentY);
		
	}
}
