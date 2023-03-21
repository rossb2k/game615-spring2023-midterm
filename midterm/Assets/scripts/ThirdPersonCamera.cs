using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; 

    public float distance = 10.0f;
    public float height = 5.0f; 
    public float damping = 2.0f; 

    private void FixedUpdate()
    {
        var desiredPosition = target.position - (target.forward * distance) + (Vector3.up * height);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);

        transform.LookAt(target);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
