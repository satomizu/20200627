using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultEnemyScore : MonoBehaviour
{
    [SerializeField]
    private ResultNum Goalnum = null;
    [SerializeField]
    private ResultNum Score = null;

    public bool CheckNum()
    {
        return Goalnum.GetMax();
    }

    public bool CheckScore()
    {
        return Score.GetMax();
    }

    public void SetNum(int num)
    {
        Goalnum.SetScore(num);
    }
    public void SetScore(int num)
    {
        Score.SetScore(num);
    }

    public void QuiqNum()
    {
        Goalnum.SetQuiqScore();
    }

    public void QuiqScore()
    {
        Score.SetQuiqScore();
    }
}
