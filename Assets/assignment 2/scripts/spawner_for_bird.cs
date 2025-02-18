using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_for_bird : MonoBehaviour
{
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject newThing = Instantiate(bird);
            Destroy(newThing, 2);
        }
    }
}
