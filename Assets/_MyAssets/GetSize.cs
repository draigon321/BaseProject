using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
//#if UNITY_EDITOR
using UnityEditor;

public class GetSize : MonoBehaviour {
	[SerializeField]
	private Vector3 x;
	public GameObject targetGameObject;
    // Use this for initialization
	void Start () 
		{

		}
	
	public Vector3 ComponentExists (GameObject targetGameObject)
		{
			 //= false;
			if (targetGameObject.GetComponent<Renderer>() != null)
			{
				Bounds xBounds=targetGameObject.GetComponent<Renderer>().bounds;
				x=xBounds.size;
			}
			else
			{
				Bounds xBounds=targetGameObject.GetComponent<Collider>().bounds;
				x=xBounds.size;
			}
			return x;
	    }
	// Update is called once per frame
	void Update () 
	{
		//if (targetGameObject.GetComponent<Renderer>() != null)
			//{
			//Bounds xBounds=targetGameObject.GetComponent<Renderer>().bounds;
			//	x=xBounds.size;
			//}
		//else
		//{
			//Bounds xBounds=targetGameObject.GetComponent<Collider>().bounds;
			//x=xBounds.size;
			//		}
		//Debug.Log(x);
	}
	
}
