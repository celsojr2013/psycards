using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleVisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Toggle()
	{
		bool active  = gameObject.activeSelf;
		gameObject.SetActive(!active);
	}
}
