using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCamera : MonoBehaviour
{
    private Vector3 offset;


    void Start()
    {
        offset = transform.position - GameObject.Find("BlueCube").transform.position;
    }

    void Update()
    {
        transform.position = GameObject.Find("BlueCube").transform.position + offset;
    }
}
