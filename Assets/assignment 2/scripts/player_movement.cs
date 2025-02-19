using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;


//Ness bike sprite (orange version) created by ASCO: https://giphy.com/stickers/rappi-8bit-MnFx9OTM10MrJjUuNc
//Original Ness sprite created by Kouichi Ooyama

public class player_movement : MonoBehaviour
{
    public float speed = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        //assigning the position of the player to a new vector
        Vector2 player = transform.position;

        //If the player moves down past the road, move the player back into the boundry
        if (transform.position.y < -4.2f)
        {
            player.y = -4.2f;
            transform.position = player;
        }
        //If the player moves up past the road, move the player back into the boundry
        else if (transform.position.y > -2.7f)
        {
            player.y = -2.7f;
            transform.position = player;
        }

        //If the player isn't going past any of the boundries, allow them to move up and down the road
        else
        {
            player.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
            transform.position = player;
        }
    }
}
