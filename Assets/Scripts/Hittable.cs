using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hittable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == LevelData.Player)
        {
            LevelData.Player.GetComponent<Player>().Die();
        }
    }
}
