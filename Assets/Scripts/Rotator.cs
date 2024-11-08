using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject glowing;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        glowing.transform.Rotate(0, 0, speed);
    }
}
