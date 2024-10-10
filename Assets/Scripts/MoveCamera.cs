using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform minhaCamera;
    public float speed = 5.0f;
    void Start()
    {
        minhaCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoverCamera();
    }

    void MoverCamera()
    {
        if(Input.GetKey(KeyCode.D)) 
        {
            minhaCamera.transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            minhaCamera.transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
