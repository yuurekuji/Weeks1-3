using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HourHandRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.z += speed * Time.deltaTime;
       
        transform.eulerAngles = rotation;
    }
}
