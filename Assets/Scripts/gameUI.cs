using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameUI : MonoBehaviour
{
    public customerObject ans;

    public Text score;
    public int scoreCount;
    public Text lives;

    // Update is called once per frame
    void Update()
    {
        if (ans.right == true)
        {
            Debug.Log("AddPoint");
            scoreCount += 10;
            score.text = scoreCount.ToString();
        }

        if (ans.wrong == true)
        {
            Debug.Log("LivesLost");
            ans.livesCount -= 1;
            lives.text = ans.livesCount.ToString();
        }

    }


}
