using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class IslandController : MonoBehaviour
{
    public float verticalSpeed;
    public Boundary boundary;

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
        float randomXPosition = Random.Range(boundary.Left, boundary.Right);
        transform.position = new Vector2(randomXPosition, boundary.Top);
    }

    void CheckBounds()
    {
        if (transform.position.y <= boundary.Bottom)
        {
            Reset();
        }
    }
}
