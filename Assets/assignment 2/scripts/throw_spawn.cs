using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throw_spawn : MonoBehaviour
{
   public GameObject prefab;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab);
        }
        
    }
}
