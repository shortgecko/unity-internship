using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float Coins()
    {
        return m_Coins;
    }

    private float m_Coins = 0f;

    public void addCoin()
    {
        m_Coins++;
    }
}