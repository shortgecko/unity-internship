using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var player = GameObject.Find("Level/Entities/Player");
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player.GetComponent<PlayerStats>().Coins().ToString();
    }
}
