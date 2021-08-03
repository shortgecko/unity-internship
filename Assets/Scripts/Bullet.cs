using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float Speed;
    public float lifetime;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce(new Vector2(Speed, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Destructable")
        {
            Destroy(collision.gameObject);
        }
    }
}
