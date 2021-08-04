using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GroundChuckCollider : MonoBehaviour
{
    private BoxCollider2D collider;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        var tilemap = GetComponent<Tilemap>();
        var player = LevelData.Player;
        Debug.Log(tilemap.size.x * tilemap.cellSize.x);
        collider.size = new Vector2(tilemap.size.x * tilemap.cellSize.x, 1);

    }

    void Update()
    {
        
    }
}
