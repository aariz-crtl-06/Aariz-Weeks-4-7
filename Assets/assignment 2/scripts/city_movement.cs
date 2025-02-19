using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Pixel Art Neighbourhood created by Albert Delacruz: https://albertd.portfoliobox.net/game
public class city_movement : MonoBehaviour
{

    public float speed = 2f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //Captures current position of image into vector
        Vector2 city = transform.position;
        
        //Once the sprite moves left enough, it will come back to the right side of the world
        if (city.x < -25)
        {
           
            city.x =+ 28;
            //Resume moving towards the left
            city.x -= speed * Time.deltaTime;
            //The vector's values that are affected is applied to the position of the sprite
            transform.position = city;
        }
        else
        {
            //The sprite will always move towards the left when it's within the boundry
            city.x -= speed * Time.deltaTime;
            transform.position = city;
        }
    }

    //Static function that allows for the slider to manipulate the speed of the sprite moving
    public void speedy(float s)
    {
        speed = s;
    }
}
