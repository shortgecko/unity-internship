using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hittable : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            var UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
            UIManager.Get("GameOverScreen").SetActive(true);
            GameObject Player = GameObject.Find("Level/Entities/Player");
            Player.GetComponent<Player>().enabled = false;
        }
    }
}
