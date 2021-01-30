using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameUI : MonoBehaviour
{
    public Text score;
    public int scoreCount;

    public customerObject answer;

    // Update is called once per frame
    void Update()
    {


        if (answer.right == true)
        {
            scoreCount += 10;
            score.text = scoreCount.ToString();
        }
    }


}
