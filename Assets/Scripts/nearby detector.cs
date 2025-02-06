using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nearbydetector : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 location = transform.position;

        if(location.x> 4 && location.y > 2)
        {
            Debug.Log("yes");
        }

        else
        {
            Debug.Log("no");
        }

    }
}
