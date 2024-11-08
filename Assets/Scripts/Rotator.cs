using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cursor;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cursor.transform.Rotate(0, speed, 0);
    }
}
