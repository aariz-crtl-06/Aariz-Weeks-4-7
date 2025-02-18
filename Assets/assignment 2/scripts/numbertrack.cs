using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class numbertrack : MonoBehaviour
{
    public TextMeshProUGUI score;
    int scoreValue = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            {
                scoreValue++;
                score.text = scoreValue.ToString();
            }
        }
    }
}
