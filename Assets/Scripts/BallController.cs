using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed = 0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        BallMovement();
    }

    private void BallMovement()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xMovement, 0.0f, zMovement);

        transform.position += moveDirection * speed * Time.deltaTime;
    }
}

