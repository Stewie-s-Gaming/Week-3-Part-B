using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCamera : MonoBehaviour
{
    private Vector3 offset;


    void Start()
    {
        offset = transform.position - GameObject.Find("RedCube").transform.position;
    }

    void Update()
    {
        transform.position = GameObject.Find("RedCube").transform.position + offset;
    }
}
