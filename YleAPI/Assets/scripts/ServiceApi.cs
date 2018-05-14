/*
Johnny Flores red.sys@live.com.mx
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using UnityEngine.UI;

public class ServiceApi : MonoBehaviour {

	private string YLEServiceURL;
	private string app_id="88ffa6e7";
	private string app_key="7107091cd73eefa6da477c8710eacd7c";
	public Transform btnPrefap;
	public Transform content;
	private Transform objBtn;
	static int limit;
	public Text msjText;

	// Use this for initialization
	void Start () {
		
		
	}


	public void LoadAPI (string wordSearch ) {
		string program = wordSearch;
		int offset=0;
		limit = 0;


		limit =+ 5;
		offset = 10;
		StartCoroutine (CoroutineAPI (program,limit,offset));

	}
	
	private IEnumerator CoroutineAPI (string program, int limit, int offset) {
		
		YLEServiceURL = "https://external.api.yle.fi/v1/programs/items.json?app_id="+app_id+"&app_key="+app_key+"&q="+program+"&offset="+ offset+"&limit="+limit;
//		Debug.Log (YLEServiceURL);
		WWW www = new WWW(YLEServiceURL);
		yield return www;
		if (www.error == null) {
//			Debug.Log(www.text);	
			InstantiateBtns(www.text);
		} else {
			Debug.Log("ERROR: " + www.error);
		}

	}

	private void InstantiateBtns(string serviceYle){
		
		JsonData values = JsonMapper.ToObject(serviceYle);

		msjText.text = "Result:";
		for (int i = 0; i < values ["data"].Count; i++) {
//			Debug.Log(values["data"][i]["title"]["fi"].ToString());
			objBtn=Instantiate (btnPrefap,new Vector3(0,0,0),Quaternion.identity) as Transform;
			objBtn.transform.SetParent(content.transform);
			objBtn.GetComponent<RectTransform>().localScale  = new Vector3 (1,1,1);
			objBtn.GetComponent<DisplayTitles> ().title = 		values ["data"] [i] ["title"] ["fi"].ToString ();
			objBtn.GetComponent<DisplayTitles> ().duration = 	values ["data"] [i] ["duration"] .ToString ();
			objBtn.GetComponent<DisplayTitles> ().type = 		values ["data"] [i] ["type"].ToString ();

		}
	
	
	}


}
