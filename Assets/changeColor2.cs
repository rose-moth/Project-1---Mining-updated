using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour {
	
	// Use this for initialization
	void Start () { //this part is used for all things that happen right at the start
		
	}
	
	
	void Update ()//this happens all the time, and can be updated continuously
	{
		if (Input.GetKeyDown (KeyCode.R)) //input must mean a entered key, and GetKeyDown() must be the function for keypress.. then Keycode must be the ID for the key itself
		{
			gameObject.GetComponent<Renderer>().material.color = Color.red; //each dot represents another level into the property we want
		}
		
		if (Input.GetKeyDown (KeyCode.G)) //gameObject references the one the script is attached to
		{
			gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		
		if (Input.GetKeyDown (KeyCode.B)) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
		
	}
}
