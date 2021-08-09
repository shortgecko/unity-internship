using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpike : MonoBehaviour
{
    public GameObject End;
    private int sign;
    private float Distance;
    private Rigidbody2D rigidBody;
    private int direction;

    void Start()
    {
        //Debug.Log(transform.TransformDirection(End.transform.position));
        rigidBody = GetComponent<Rigidbody2D>();
        Vector3 currentDirection = (transform.position - End.transform.position).normalized;
        Debug.Log(currentDirection.x);
        direction = (int)currentDirection.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x  < End.transform.position.x)
        {
            rigidBody.AddForce(new Vector2(direction * -5, rigidBody.velocity.y));
        }
    }
}
