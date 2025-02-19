using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bird sprite by saphatthachat pixel cat: https://www.shutterstock.com/image-vector/vector-pixel-art-bird-white-isolated-1074968357
public class bird_movement : MonoBehaviour
{
    public float speed = 12f;
    //Makes a reference to the sprite renderer
    SpriteRenderer spriteRenderer;
    //Creates a variable to manage the colour
    public Color feathers;
    void Start()
    {
        //references the sprite renderer component from the inspector and allows the variable in code to influence it
        spriteRenderer = GetComponent<SpriteRenderer>();
        //This allows for a random colour slected from the colour section of sprite renderer
        spriteRenderer.color = Random.ColorHSV();
    }


    void Update()
    {
        //vector to take position of bird prefab for manipulation
        Vector2 bird = transform.position;

        //When the sprite goes left enough past the camera, it'll come back to the right side and begin to move towards left again
        if (bird.x < -25)
        {

            bird.x = +28;
            bird.x -= speed * Time.deltaTime;
            transform.position = bird;
        }

        //makes the sprite always move towards the left otherwise
        else
        {
            bird.x -= speed * Time.deltaTime;
            transform.position = bird;
        }
    }
}
