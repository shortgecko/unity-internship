using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float Speed = 700;
    public float jumpForce = 800;
    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask GroundLayer;
    public GameObject BulletPrefab;
    public Transform bulletPosition;

    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private bool Grounded
    {
        get
        {
            return Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, GroundLayer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject.Instantiate(BulletPrefab, bulletPosition.position, Quaternion.identity);
        }

        if(Input.GetButtonDown("Jump") && Grounded)
        {
            rigidBody.AddForce(new Vector2(0, jumpForce));
        }

        rigidBody.velocity = new Vector2(Speed, rigidBody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Math.Abs(collision.contacts[0].normal.x) > 0.5f)
        {
            Die();
        }
    }


    public void Die()
    {
        foreach (var component in GetComponents(typeof(Component)))
        {
            var UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
            UIManager.Get("GameOverScreen").SetActive(true);
            var type = component.GetType();
            if (type != typeof(SpriteRenderer) && type != typeof(Transform))
            {

                Destroy(component);
            }
        }
    }
}
