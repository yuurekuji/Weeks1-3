using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01f;
  
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        Vector2 Screens = Camera.main.WorldToScreenPoint(pos);
        transform.position = pos;

        if (Screens.x >= Screen.width)
        {
            speed = -speed;
            transform.position = pos;

        }
        else if (Screens.x <= 0) { 
            speed = -speed;
            transform.position = pos;
        }

    }
}
