using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city_movement : MonoBehaviour
{

    public float speed = 2f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 city = transform.position;
        

        if (city.x < -25)
        {
           
            city.x =+ 28;
            city.x -= speed * Time.deltaTime;
            transform.position = city;
        }
        else
        {
            city.x -= speed * Time.deltaTime;
            transform.position = city;
        }
    }

    public void speedy(float s)
    {
        speed = s;
    }
}
