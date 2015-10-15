using UnityEngine;
using System.Collections;

public class cubeBehavior : MonoBehaviour {
    //this makes a dropdown menu list? declaring it as a variable also makes it appear as a component
    public Oretype myType;
    //anything in this script will affect all 3 cubes

	// Use this for initialization
	void Start () {
        //we made each type the color name... the dot modifier means the specific type of that type. it's like a / in file extensions
        if (myType == Oretype.Bronze)
            //we type gameObject first because it accesses the object itself?
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        if (myType == Oretype.Silver)
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        if (myType == Oretype.Gold)
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        if (myType == Oretype.Kryptonite)
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
	}
    //function that indicates click, like mouse_down in gamemaker
    void OnMouseDown()
    {
        Destroy(gameObject);//like instance_destroy()

        //if the variable myType is set to 1(the bronze ore, as declared in the enum)
        if (myType == Oretype.Bronze)
        { //one less on the bronzeCounter
            GameController.bronzeCount--;
            //add a point to the appropriate area
            GameController.score += GameController.bronzePoints;

        }
        else if (myType == Oretype.Silver)
        {
            GameController.silverCount--;

            GameController.score += GameController.silverPoints;

        }
        else if (myType == Oretype.Gold)
        {
            GameController.goldCount--;
            GameController.score += GameController.goldPoints;

        }
    }



	
	// Update is called once per frame
	void Update () {
	
	}
}
