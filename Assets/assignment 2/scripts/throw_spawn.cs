using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throw_spawn : MonoBehaviour
{
    //Allows script to reference prefabs for instantiating and destroying them
    public GameObject prefab;
    public GameObject prefab2;
    //Current object is the prefab the player is currently holding
    public GameObject currentObject;

    void Start()
    {


    }


    void Update()
    {

    }
    //Runs remove function to destroy current option to allow the next item to spawn by assigning the right prefab to the current object
    //The buttons will use these functions to allow for player choice during play
    public void newspaper()
    {
        remove();
        currentObject = Instantiate(prefab);

    }
    //Runs remove function to destroy current option to allow the next item to spawn by assigning the right prefab to the current object
    //The buttons will use these functions to allow for player choice during play
    public void tomato()
    {
        remove();
        currentObject = Instantiate(prefab2);
        

    }
    public void remove()
    {
        //If there isn't nothing in the current object being held, destroy the current object
        if (currentObject != null)
        {
            Destroy(currentObject);
        }

    }
}
