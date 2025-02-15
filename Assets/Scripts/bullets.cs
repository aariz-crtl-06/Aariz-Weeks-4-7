using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 direction;

    public SpriteRenderer spriteRenderer;
    void Start()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        direction = mouse - transform.position;

        if (mouse.z < 90)
        {
            transform.right = direction;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos += speed * direction * Time.deltaTime;
        transform.position = pos;

        
    }
}
