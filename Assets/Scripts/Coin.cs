using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var collisionObject = collision.gameObject;
        if(collisionObject.layer == LayerMask.NameToLayer("Player"))
        {
            collisionObject.GetComponent<PlayerStats>().addCoin();
            Destroy(gameObject);
        }
    }
}
