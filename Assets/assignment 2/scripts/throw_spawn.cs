using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throw_spawn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    public GameObject currentObject;

    void Start()
    {


    }


    void Update()
    {

    }

    public void newspaper()
    {
        remove();
        currentObject = Instantiate(prefab);

    }

    public void tomato()
    {
        remove();
        currentObject = Instantiate(prefab2);
        

    }

    public void remove()
    {
        if (currentObject != null)
        {
            Destroy(currentObject);
        }

    }
}
