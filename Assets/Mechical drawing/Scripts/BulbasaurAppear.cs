using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbasaurAppear : MonoBehaviour
{
    public bool isGameOn = false;
    public bool isBallOnGround = false;
    public bool dis = false;
    public bool rotate = false;
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;

    public AnimationCurve bigger;
    [Range(0, 1)]
    public float b;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) // this is to turn on the game when the mouse is pressed. 
        {
            isGameOn = !isGameOn;
        }

        Vector3 pos = transform.position;
        //////////////////////////////////////
        ////////// Make bulba appear  ////////
        //////////////////////////////////////
        ///

        // this condition is to start the bulbasaur falling animation. It checks if the bulbasaur is greater than a specific height and if that is true then the bulba will fall until said height of 0 (this is due to the lack of colliders).
        // the Boolean isGameOn is also checked so that the ball does not fall when the game has not even begun yet.
        if (pos.y > 0 && isGameOn == true)
        {
            pos.y -= 0.7f * Time.deltaTime;
        }
        // this else statment is to check if the boolean is false, if the boolean is false it means that the game is turned off and it should reset back to the original state. 
        if (isGameOn == false)
        {
            // 2 is the original y value of the bulba, so when the boolean is false, then the positon will change back to the original giving the player a sense of actually resetting the game. 
            pos.y = 2;
        }

        if (pos.y <= 0.2f)
        {
            isBallOnGround = true; // this sets the boolean to true when the position of the bulba is where we want it to be.
        }
        if (Input.GetKeyDown(KeyCode.Space) && isBallOnGround == true) // this checks if the player presses space when the IsBallOnGround Boolean is true, if it is then turn dis to true which runs the subsequent codes. 
        {
            dis = true;
        }

        // this checks if the boolean isGameOn is false, if it is then it hard sets the isBallOnGround boolean to false to stop the bulba from increasing and decreasing in size.
        if (isGameOn == false)
        {
            isBallOnGround = false;
            dis = false;
        }

        if (dis == true && t<0.05)

        {
            t += 0.1f * Time.deltaTime;

        }
        if(dis == false) // this checks if the dis boolean is false and if it is it resets the value 
        {
            t = 0;
        }


        //////////////////////////////////////////////////////////////
        ///////// Make bulba shake when appear with lerp  ////////////
        //////////////////////////////////////////////////////////////
        
        Vector3 fun = transform.eulerAngles;
        fun.z = Mathf.Lerp(0, 360, bigger.Evaluate(b)); /// this lerps the z or the rotation of bulba and evaluates based off of my animation curve b
        transform.eulerAngles = fun;

        if (t > 0.05) // this checks if the t is greater than 0.05 and then sets the rotate boolean to true if it is.
        {
            rotate = true;
     
        }
        else // sets to false if else
        {
            rotate = false;
        }
        if(rotate == true) // if the rotate function is true, then increase b which will rotate bulba 360 degrees. 
        {
            b += 5 * Time.deltaTime;
        }
        if(rotate == false) // this makes sure that when rotate is false when the player resets, the b will be reset to 0 so that bulba can rotate again the next time.
        {
            b = 0;
        }
    
        transform.localScale = Vector3.one * curve.Evaluate(t);
        // this line of code forces the bulba to retain the order inside the layers, if this line of code is missing the bulba will shift back to a z position of 0 when the game is run. 
        pos.z = 1.5f;

        transform.position = pos;
    }
}
