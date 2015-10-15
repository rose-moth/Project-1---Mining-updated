using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    //makes cubePrefab a gameObject? but it was already... I guess so it knows what to assign the script to
    public GameObject cubePrefab;

    //whenever you make a prefab, declare it as a GameObject in the main behavioral script
    public GameObject BronzeCube;
    public GameObject SilverCube;
    public GameObject GoldCube;
    //public GameObject kryptonitePrefabCube;

    // these are the number of cubes output
    public static int bronzeCount = 0;
    public static int silverCount = 0;
    public static int goldCount = 0;
    //public static int KryptoCount = 0;

    //these are the scorepoints for the player? each cube is worth this many points

    public static int bronzePoints = 1;
    public static int silverPoints = 10;
    public static int goldPoints = 100;
    //the player's initial score at start? it's here so any other function can read it
    public static int playerScore = 0;
    public static int score = 0;


    //both declare and assign, and make float these variables...
    float spawnTime = 2.0f; //every 3 frames/seconds(?) it spawns
    //float spawnFrequency = 3.0f
    float timeToAct = 0.0f; //starts immediately

    //each time you need something involving intervals of time, think of float variable stopwatches 
    float spawnSilverTime = 6.0f;
    float stopSpawnTime = 6.0f;
    float submerged = 100000.0f;

    private bool recentlySpawnedGold = false;



    void Start()
    {
        //initiate timeToAct
        //do this by saying the variable to be initiated, and setting it to something.
        //+= means  it won't just start at 0
        //the timeToAct variable acts as a control for the game to know when to do something (timer)
        timeToAct += spawnTime;
    }


    void Update()
    {
        {
                // If the left mouse button is pressed down...
                if (Input.GetMouseButtonDown(0) == true)
                {
                    AudioSource audio = GetComponent<AudioSource>();
        
                    audio.Play();
                }
                // If the left mouse button is released...
                

        //Time.time = seconds since game began
        //this means right after the initiated TimeToAct we
        //so, this means, if timeToAct has passed and it's less than the stop time 
        //if (Time.time >= timeToAct && Time.time < spawnSilverTime + stopSpawnTime) {
        if (Time.time >= timeToAct)
        {

            // Check to spawn gold first, since it's highest priority
            if (bronzeCount == 2 && silverCount == 2 && recentlySpawnedGold == false)
            {


                Instantiate(GoldCube,
                            new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
                            Quaternion.identity);
                goldCount++;

                recentlySpawnedGold = true;
                timeToAct += spawnTime;
            }
            else if (bronzeCount < 4)
            {
                Instantiate(BronzeCube,
                            new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
                            Quaternion.identity);
                bronzeCount++;
                recentlySpawnedGold = false;
                timeToAct += spawnTime;
            }
            else if (bronzeCount >= 4)
            {
                Instantiate(SilverCube,
                            new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
                            Quaternion.identity);
                silverCount++;
                recentlySpawnedGold = false;
                timeToAct += spawnTime;
            }


            







                //we instantiate (a function that creates our prefab at a place at a rotatio 
                //GameObject myCube makes a new myCube each instantiation
                //(GameObject) tells instantiation that the object created is a GameObject... Casting?
                // GameObject myCube = (GameObject) Instantiate(cubePrefab,
                //set the inside values to be random, so that cubes appear all over the place w/o manual changing
                //   new Vector3(Random.Range(-9f,9f), Random.Range(-3f,-5f), 0),Quaternion.identity);

                //  myCube.GetComponent<Renderer>().material.color = Color.red;
                //if the variable hits the new stopwatch, spawn white
                // if (timeToAct >= spawnSilverTime) {
                // myCube.GetComponent<Renderer>().material.color = Color.white;
                //if not, keep spawning red 
                // } else {
                // myCube.GetComponent<Renderer>().material.color = Color.red;
                // }
                //and then we reset the timeToAct so it does it over and over
                //timeToAct += spawnTime;

            }
        }
    }
}
