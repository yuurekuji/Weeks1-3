using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShake : MonoBehaviour
{
    public bool isGameOn = false;
    public bool isBallOnGround = false;

    public AnimationCurve curve;
    [Range(0,1)]
    public float t;
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
        if(pos.y <= 0.2f)
        {
            isBallOnGround = true; // this sets the boolean to true when the position of the ball is where we want it to be.
        }
        if (isBallOnGround == true && isGameOn == true) // this if statement checks both booleans are true, if they are then the animation can occur. We create this check to ensure that the animation does not happen outside of when we want it to. 
        {
            t += 0.2f *Time.deltaTime; // we multiply by a delta time in order for the frames to be consitent and to not have frames be skipped during unity run times. 

            if (t > 0.25) // this if statement checks if the t is below 0.25 and resets back to 0.1 if it is. 
            {
                t = 0.1f; // reset back to 0.1f
            }
            // this transforms the scale of the ball based off the animation curve
            transform.localScale = Vector3.one * curve.Evaluate(t);
          
        }
        // this checks if the boolean isGameOn is false, if it is then it hard sets the isBallOnGround boolean to false to stop the ball from increasing and decreasing in size.
        if (isGameOn == false)
        {
            isBallOnGround = false;
        }

        // this line of code forces the ball to retain the order inside the layers, if this line of code is missing the ball will shift back to a z position of 0 when the game is run. 
        pos.z = 1.5f;
        transform.position = pos;
    }
}
