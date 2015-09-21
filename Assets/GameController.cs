using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//makes cube a gameObject? but it was already... I guess so it knows what to assign the script to
	public GameObject Cube;
	//putting it after bool declares it as a variable, and then you assign it in 1 step
	bool cubeSpawned = false;

	bool TimeToSpawnCube(){ //TimeToSpawnCube must be a true or false function? checks whether it's time to do the spawn
		//
		if (Time.time >= 3.0f && !cubeSpawned) { //! = false
			return true; //if 3 seconds have passed and there's no cube there, change the bool to true
	
		} else {
			return false; //if it's not at 3 seconds yet, still false
		}
	}


	//void means there's no value to return outside of function
	void SpawnCube() {
		//vector3 means there are 3 coordinates in the vector, it's also a variable type
		Vector3 cubePosition = new Vector3 (0.0f, 0.0f, 0.0f); //use new vector to assign value
	
		Instantiate (Cube, cubePosition, Quaternion.identity); //use cube, at origi, with no rotation

		cubeSpawned = true;
	}


	void Start () {
	
	}
	
	
	void Update () {
		if (TimeToSpawnCube()) { //if the function is met,
			//just run the function
			SpawnCube();
	}
}
}