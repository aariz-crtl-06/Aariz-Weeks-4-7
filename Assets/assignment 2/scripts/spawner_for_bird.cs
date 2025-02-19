using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_for_bird : MonoBehaviour
{
    //Allows for script to utilize bird prefab
    public GameObject bird;
    void Start()
    {
        
    }

    void Update()
    {
        //If space is pressed, spawn the bird prefab and destroy it after 2 seconds
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Creates a game object that references and spawns bird game object to destroy itself
           GameObject newThing = Instantiate(bird);
            Destroy(newThing, 2);
        }
    }
}
