using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 StartPosition;
    void Start()
    {
        StartPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ScreenTrigger")
            transform.position = StartPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
    }
}
