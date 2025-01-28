using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnonandoff : MonoBehaviour
{
    public bool isGameOn = false;

    // Start is called before the first frame update
    void Start()
    {


        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            isGameOn = !isGameOn;
        }

       
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;

        if(isGameOn == true)
        {
            pos.z = 3;

            
        }
        else
        {
            pos.z = 0;
        }
        transform.position = pos;
    }
}
