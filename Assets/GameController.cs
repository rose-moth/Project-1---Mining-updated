using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    
	//makes cubePrefab a gameObject? but it was already... I guess so it knows what to assign the script to
	public GameObject cubePrefab;
	//both declare and assign, and make float these variables...
	float spawnFrequency = 2.0f; //every 3 frames/seconds(?) it spawns
    float timeToAct = 0.0f; //starts immediately
    //each time you need something involving intervals of time, think of float variable stopwatches 
    float spawnSilverTime = 6.0f;
    float stopSpawnTime = 6.0f;


	void Start () {
	    //initiate timeToAct
        //do this by saying the variable to be initiated, and setting it to something.
        //+= means  it won't just start at 0
        //the timeToAct variable acts as a control for the game to know when to do something (timer)
        timeToAct += spawnFrequency;
	}
	
	
	void Update () {
        //Time.time = seconds since game began
        //this means right after the initiated TimeToAct we
        //so, this means, if timeToAct has passed and it's less than the stop time 
        if (Time.time >= timeToAct && Time.time < spawnSilverTime + stopSpawnTime) {
		
        //we instantiate (a function that creates our prefab at a place at a rotation a cube 
            //GameObject myCube makes a new myCube each instantiation
            //(GameObject) tells instantiation that the object created is a GameObject... Casting?
            GameObject myCube = (GameObject) Instantiate(cubePrefab,
                //set the inside values to be random, so that cubes appear all over the place w/o manual changing
                new Vector3(Random.Range(-9f,9f), Random.Range(-3f,-5f), 0),Quaternion.identity);
                  
                myCube.GetComponent<Renderer>().material.color = Color.red;
            //if the variable hits the new stopwatch, spawn white
            if (timeToAct >= spawnSilverTime) {
                myCube.GetComponent<Renderer>().material.color = Color.white;
                //if not, keep spawning red 
            } else {
                myCube.GetComponent<Renderer>().material.color = Color.red;
            }
            //and then we reset the timeToAct so it does it over and over
            timeToAct += spawnFrequency;
           
        }
}
}