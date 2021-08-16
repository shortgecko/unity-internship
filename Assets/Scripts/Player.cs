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
    private BoxCollider2D boxCollider;
    private bool jump = false;


    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    private bool Grounded
    {
        get
        {
            return Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, GroundLayer);
        }
    }

    private bool Touching
    {
        get
        {
            return Physics2D.OverlapCircle(bulletPosition.position, 0.1f, GroundLayer); ;
        }
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump") && Grounded)
        {
            jump = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject.Instantiate(BulletPrefab, bulletPosition.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (jump)
        {
            rigidBody.AddForce(new Vector2(0, jumpForce));
            jump = false;
        }

        rigidBody.velocity = new Vector2(Speed, rigidBody.velocity.y);


        if (Touching)
        {
            
            Die();
        }

    }






    public void Die()
    {

        foreach (var component in GetComponents(typeof(Component)))
        {
            var UIManager = LevelData.UIManager;
            UIManager.Get("GameOverScreen").SetActive(true);
            Type componentType = component.GetType();

            if (componentType != typeof(SpriteRenderer) && componentType != typeof(Transform))
            {
                Destroy(component);
            }
        }
    }
}
