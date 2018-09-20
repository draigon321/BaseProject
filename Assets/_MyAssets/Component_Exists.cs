using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
//#if UNITY_EDITOR
using UnityEditor;

public class Component_Exists : MonoBehaviour {
	//public  GameObject gameObjectToCheck;


    // Use this for initialization
    void Start () {

    }
	public bool ComponentExists (GameObject gameObjectToCheck)
	{
		bool x = false;
		if (gameObjectToCheck.GetComponent<Renderer>() != null)
	        
		{
			x=true;
		}
		return x;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
