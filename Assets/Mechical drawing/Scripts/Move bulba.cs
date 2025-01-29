using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Movebulba : MonoBehaviour
{

    float speed = 0.8f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 scale = transform.localScale;


        // The condition checks if bulba is at a height lower than 0.001 which is the ideal height which I have decided,
        // then it checks if the scale of bulba is at 0.0975 to make sure that the animation does not start for movement while bulba is spinning

        if (pos.y <= 0.001 && scale.x >= 0.0975 && scale.y >= 0.0975) 
        {
            pos.x += speed * Time.deltaTime; // this is a shift in bulbas pos.x value at a consitent rate.

            transform.position = pos;
        }

        if (pos.y == 2) // this chekcs if the pos is back to the original to give the toy an ideal reset function, whithout using any unity components.
        {
            pos.x = 0; // 0 is the original pos of bulbasaur
            transform.position = pos;
        }

        if (pos.x >= 1.5) // this checks the width of bulba so that the movent does not go past the screen.
        {
            speed = -speed; // this reverses the direction bulba goes in.
            transform.position = pos;

        }
        else if (pos.x <= -1.5 ) // this is the opposite check
        {
            speed = -speed; // this reverses the direction bulba goes in.
            transform.position = pos; 
        }

        transform.localScale = scale;

    }
}

