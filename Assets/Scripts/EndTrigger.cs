using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == LevelData.Player)
        {
            var UIManager = LevelData.UIManager.GetComponent<UIManager>();
            UIManager.Get("WinScreen").SetActive(true);
            int buildIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(buildIndex + 1);
        }
    }

}
