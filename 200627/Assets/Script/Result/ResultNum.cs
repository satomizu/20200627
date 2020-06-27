using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultNum : MonoBehaviour
{
    private bool maxtrue = false;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        maxtrue = false;
    }

    public void SetScore(int Set)
    {
        score = Set;
    }

    public bool GetMax()
    {
        maxtrue = false;
        int num = int.Parse(GetComponent<Text>().text);
        if (score > num)
        {
            num += 3;
            if (score <= num)
            {
                num = score;
                maxtrue = true;
            }
            GetComponent<Text>().text = num.ToString();
        }
        else
        {
            maxtrue = true;
        }
        return maxtrue;
    }

    public void SetQuiqScore()
    {
        GetComponent<Text>().text = score.ToString();
        maxtrue = true;
    }
}
