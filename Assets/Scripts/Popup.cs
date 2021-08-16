using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject popupObject;

    private void Start()
    {
        popupObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == LevelData.Player)
        {
            popupObject.SetActive(true);
        }
    }
}
