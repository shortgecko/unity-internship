using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;
    public float Speed = 700;
    public float jumpForce = 800;
    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask GroundLayer;
    public GameObject BulletPrefab;
    public Transform bulletPosition;

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, GroundLayer);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject.Instantiate(BulletPrefab, bulletPosition.position, Quaternion.identity);
            Debug.Log("shoot!");
        }

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidBody.AddForce(new Vector2(0, jumpForce));
        }

        float x = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(Speed , rigidBody.velocity.y);


    }

    
}
