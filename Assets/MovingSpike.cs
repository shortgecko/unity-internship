using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpike : MonoBehaviour
{
    public GameObject End;
    private int sign;
    private float Distance;
    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        if(transform.position.x < End.transform.position.x)
        {
            sign = 1;
        }
        else if (transform.position.x > End.transform.position.x)
        {
            sign = -1;
        }

        Distance = Vector2.Distance(transform.position, End.transform.position);
        Debug.Log(Distance);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < End.transform.position.x)
        {
            rigidBody.velocity = (new Vector2(sign * 1, rigidBody.velocity.y));
        }
    }
}
