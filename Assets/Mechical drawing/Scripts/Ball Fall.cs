using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallFall : MonoBehaviour
{
    public bool isGameOn = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        //this conditional statement is to check if the player right or left clicks with the mouse, if they do then the IsGameOn boolean will change to the opposite and trigger the if statement below to change start the falling animation of the ball
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            isGameOn = !isGameOn;
        }
        // use a vector2 as I will not be changing the z value in anyway and just the y value. 
        Vector2 pos = transform.position;

        // this condition is to start the ball falling animation. It checks if the ball is greater than a specific height and if that is true then the ball will fall until said height of -0.3 (this is due to the lack of colliders).
        // the Boolean isGameOn is also checked so that the ball does not fall when the game has not even begun yet.
        if (pos.y > -0.3 && isGameOn == true)
        {
            pos.y -= 0.7f * Time.deltaTime;
        }
        // this else statment is to check if the boolean is false, if the boolean is false it means that the game is turned off and it should reset back to the original state. 
        if (isGameOn == false)
        {
            // 2 is the original y value of the ball, so when the boolean is false, then the positon will change back to the original giving the player a sense of actually resetting the game. 
            pos.y = 2;
        }
        transform.position = pos;
    }
}