using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Clock : MonoBehaviour
{
    public float speed;
    public AudioSource audioSource;
    public AudioClip clip;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
       t+= Time.deltaTime;
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;

        if (t > 1)
        {
            t = 0;
        }

        if(t >= 0.5)
        {
            audioSource.Play();
        }

        //if(audioSource.isPlaying)
        //{
        //    audioSource.isPlaying=!;
        //}

      
    }
}
