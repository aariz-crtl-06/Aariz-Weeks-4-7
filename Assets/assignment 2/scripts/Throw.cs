using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Newspaper pixel sprite art by Pixeleart: https://www.vecteezy.com/vector-art/21787937-news-paper-in-pixel-art-style
//Tomato sprite by Nphan: https://ca.pinterest.com/pin/556968678913903004/
public class Throw : MonoBehaviour
{
    //Allows for animation curve within the inspector
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public Vector2 start;
    public Vector2 end;
    //Conditional to check if throwing is happening 
    bool isThrowing = false;
    float speedd = 4f;

    void Start()
    {
        //time starts off at zero for animation curve
        t = 0;
        start = transform.position;

    }

    void Update()
    {
        //stores position of object
        Vector2 pos = transform.position;

        //when right click is pressed and nothing is being thrown, reset the timer and make throwing true
        if (Input.GetMouseButtonDown(1) && !isThrowing)
        {
            t = 0;
            isThrowing = true;
        }

        //When isThrowing is true, allow the timer to run
        if (isThrowing)
        {
            t += Time.deltaTime;

            //Once the timer reaches 1 second, throwing stops 
            if (t > 1)
            {
                t = 1;
                isThrowing = false;
            }
            //This plays the lerp animation curve to make the sprite move
            transform.position = Vector2.Lerp(start, end * 1.4f, curve.Evaluate(t));
        }
        //Once the timer is over, make the sprite that was thrown move with the background into offscreen so it appears like the item
        //is staying back while the player moves forward
        if (t == 1)
        {
            pos.x -= speedd * Time.deltaTime;
            transform.position = pos;
        }
    }

}