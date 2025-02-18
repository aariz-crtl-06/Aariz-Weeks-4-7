using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_movement : MonoBehaviour
{
    public float speed = 12f;
    SpriteRenderer spriteRenderer;
    public Color feathers;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bird = transform.position;


        if (bird.x < -25)
        {

            bird.x = +28;
            bird.x -= speed * Time.deltaTime;
            transform.position = bird;
        }
        else
        {
            bird.x -= speed * Time.deltaTime;
            transform.position = bird;
        }
    }
}
