using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Step size horizontal")]
    float step_size_horizontal;
    [SerializeField]
    [Tooltip("Step size vertical")]
    float step_size_vertical;
    float step_init = 0.1f;
    Vector3 startPosition;
    float acceleration = 0.2f;
    float limit_vertical = 16f;
    float limit_horizontal = 43f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        step_size_horizontal = step_init;
        step_size_vertical = step_init;

    }

    // Update is called once per frame
    void Update()
    {
        if ((!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)))
        {
            step_size_horizontal = step_init;
        }
        if ((!Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W)))
        {
            step_size_vertical = step_init;
        }
        if (!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && transform.position.x < limit_vertical)
        {
            step_size_horizontal += acceleration;
            transform.position += new Vector3(step_size_horizontal * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && transform.position.x > -limit_vertical)
        {
            step_size_horizontal += acceleration;
            transform.position += new Vector3(-step_size_horizontal * Time.deltaTime, 0, 0);
        }
        if (!Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W) && transform.position.y < limit_horizontal)
        {
            step_size_vertical += acceleration;
            transform.position += new Vector3(0, step_size_vertical * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W) && transform.position.y > -limit_horizontal)
        {
            step_size_vertical += acceleration;
            transform.position += new Vector3(0, -step_size_vertical * Time.deltaTime, 0);
        }
    }
}
