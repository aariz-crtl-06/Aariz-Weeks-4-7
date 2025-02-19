using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TMPro references text related content to a script
using TMPro;

public class numbertrack : MonoBehaviour
{
    //Creaes a dynamic text
    public TextMeshProUGUI score;
    //This dynamic text will reference this score value tracker
    int scoreValue = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the right click is pressed, the score will go up by one
        if (Input.GetMouseButtonDown(1))
        {
            {
                //Converts the scoreValue variable into a string that the dynamic text can reference
                scoreValue++;
                score.text = scoreValue.ToString();
            }
        }
    }
}
