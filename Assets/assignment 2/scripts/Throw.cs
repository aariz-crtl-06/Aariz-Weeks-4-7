using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public Vector2 start;
    public Vector2 end;
    bool isThrowing = false;
    float speedd = 4f;

    void Start()
    {
        
        t = 0;
        start = transform.position;

    }

    void Update()
    {
        
        Vector2 pos = transform.position;

        if (Input.GetMouseButtonDown(1) && !isThrowing)
        {
            t = 0;
            isThrowing = true;
        }

        if (isThrowing)
        {
            t += Time.deltaTime;

            if (t > 1)
            {
                t = 1;
                isThrowing = false;
            }

            transform.position = Vector2.Lerp(start, end * 1.4f, curve.Evaluate(t));
        }

        if (t == 1)
        {
            pos.x -= speedd * Time.deltaTime;
            transform.position = pos;
        }
    }

    public void speedy(float s)
    {
        speedd = s;
    }
}