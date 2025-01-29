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

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            isGameOn = !isGameOn;
        }
        Vector3 pos = transform.position;

        if(pos.y > -0.3 && isGameOn == true)
        {
            pos.y -= 0.5f * Time.deltaTime;
        }
        transform.position = pos;
    }
}
