using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float m_Coins = 0f;

    public float Coins()
    {
        return m_Coins;
    }

    public void AddCoin()
    {
        m_Coins++;
    }
}