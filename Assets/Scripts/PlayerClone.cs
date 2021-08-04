using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClone : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private float Speed = 700;
    private float jumpForce = 800;
    private float groundCheckRadius;
    private Player Player;

    public Transform groundCheckPosition;
    public GameObject BulletPrefab;
    public Transform bulletPosition;

    public LayerMask JumpLayer;
    public LayerMask Ground;

    private void Start()
    {
        Player = LevelData.Player.GetComponent<Player>();
        Speed = Player.Speed;
        jumpForce = Player.jumpForce;
        groundCheckRadius = 0.01f;


        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private bool Grounded
    {
        get
        {
            return Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, Ground);
        }
    }

    private bool Touching(out Collider2D hit)
    {
       hit = Physics2D.OverlapCircle(bulletPosition.position, 1f, JumpLayer);
       return (bool)hit;
    }

    void Shoot()
    {
       GameObject.Instantiate(BulletPrefab, bulletPosition.position, Quaternion.identity);
    }
    bool jumped = false;
    void Jump()
    {
        if(Grounded )
        {
            rigidBody.AddForce(new Vector2(0, jumpForce ));
        }
    }

    
    void Update()
    {

        rigidBody.velocity = new Vector2(Speed, rigidBody.velocity.y);

        if(Touching(out Collider2D hit))
        {
            if(hit.GetComponent<Hittable>())
            {
                if(hit.tag == "Destructable")
                {
                    Shoot();
                }
                else
                {
                    Jump();
                }
            }
            else
            {
                //Jump();
            }
        }

        Debug.Log(Grounded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}