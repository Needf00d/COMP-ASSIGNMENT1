﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcenController : MonoBehaviour
{
    public float verticalSpeed = 0.1f;
    public float resetPosition = 4.8f;
    public float resetPoint = -4.8f;


    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

 
    /// This method moves the ocean down the screen by verticalSpeed

    void Move()
    {
        Vector2 newPosition = new Vector2(0.0f, verticalSpeed);

        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }


    /// <summary>
    ///  This method resets the ocean to the ResetPosition
    /// </summary>
    void Reset()
    {
        transform.position = new Vector2(0.0f, resetPosition);
    }

    void CheckBounds()
    {
        if(transform.position.y <= resetPoint)
        {
            Reset();
        }
    }
}
