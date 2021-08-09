using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReserPlayer : MonoBehaviour
{
    public GameObject spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = new Vector3(spawn.transform.position.x, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
    }
}
