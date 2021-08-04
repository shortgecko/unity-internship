using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class LevelData
{
    public static GameObject Player
    {
        get
        {
            return GameObject.Find("Level/Entities/Player"); 
        }
    }
    public static UIManager UIManager
    {
        get
        {
            return GameObject.Find("UIManager").GetComponent<UIManager>();
        }
    }


}
