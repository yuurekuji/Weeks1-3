using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnonandoff : MonoBehaviour
{
    public bool isGameOn = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this conditional statement is to check if the player right or left clicks with the mouse, if they do then the IsGameOn boolean will change to the opposite and trigger the if statement below to change z value
        
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            isGameOn = !isGameOn;
        }

        //we use vector 3 as I wish to configure the Z value of the positions.
        Vector3 pos = transform.position;

        // this if statement checks if the boolean for isGameOn is true, if it is then it will change the pos of the Z value to 3 ( a value behind all other layers ) 
        // by using layers with Z value, it can create the illusion of the object dissapearing without using the destroy function. 
        if(isGameOn == true)
        {
            //this pos is set to 3 to push it to the back of everything which is going on. 
            pos.z = 3;

            
        }
        // conditional checks if it is false to revert back to the game off screen
        else 
        {
            // a pos of 0 pushes it to the front of every other game identity to fake the screen going back off. 
            pos.z = 0;
        }
        transform.position = pos;
    }
}
