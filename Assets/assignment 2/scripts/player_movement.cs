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
        if (transform.position.y < -4.2f)
        {
            player.y = -4.2f;
            transform.position = player;
        }

        else if(transform.position.y > -2.7f)
        {
            player.y = -2.7f;
            transform.position = player;
        }

        else
        {
            player.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
            transform.position = player;
        }
    }
}
