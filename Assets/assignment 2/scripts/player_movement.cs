using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class player_movement : MonoBehaviour
{
    public float speed = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 player = transform.position;

        player.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        player.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
    }
}
