using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class jump : MonoBehaviour
{
    [Range(0, 1)]
    public float t;
    public float speed = 1;
    public AnimationCurve curve;

    public bool isJumping = false;

    



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;


        }
        if(isJumping == true)
        {
            jumping();
        }

    }

    void jumping()
    {

        Vector2 pos = transform.position;
        pos.y = speed* transform.up  * Time.deltaTime * curve.Evaluate(t); 
  

    t += Time.deltaTime;

        if (t > 1)
        {
            isJumping = false;
            t = 0;
        }

    }
}

