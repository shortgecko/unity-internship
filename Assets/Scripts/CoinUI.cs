using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var player = LevelData.Player.GetComponent<PlayerStats>();
        if(player != null)
        {
            GetComponent<TextMeshProUGUI>().text = player.Coins().ToString();
        }
    }
}
