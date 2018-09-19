using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
//#if UNITY_EDITOR
using UnityEditor;

public class Component_Exists : MonoBehaviour {
    public  GameObject gameObjectToCheck;


    // Use this for initialization
    void Start () {
        if (gameObjectToCheck.GetComponent<Rigidbody>() != null)
        {
            //do something
        }
    }
	public ComponentExists()
    {

    }
	// Update is called once per frame
	void Update () {
		
	}
}
