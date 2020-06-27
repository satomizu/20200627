using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManger : MonoBehaviour
{
    [SerializeField]
    private ResultEnemyScore red = null;
    [SerializeField]
    private ResultEnemyScore bull = null;
    [SerializeField]
    private ResultEnemyScore green = null;

    [SerializeField]
    private ResultNum Total = null;

    [SerializeField]
    private GameObject Button = null;

    private uint[] score = new uint[3];

    private int flug = 0;
    private int totalscore = 0;

    Score gameScore;

    // Start is called before the first frame update
    void Start()
    {

        gameScore = GameObject.Find("Score").GetComponent<Score>();
        flug = 0;
        score[0] = (uint)gameScore.GetAnswerTrue1();
        score[1] = (uint)gameScore.GetAnswerTrue2();
        score[2] = (uint)gameScore.GetAnswerTrue3();

        for (int i = 0; i < 3; i++)
        {
            totalscore = gameScore.TotalScore;
        }

        Button.SetActive(false);
        red.SetNum((int)score[0]);
        bull.SetNum((int)score[1]);
        green.SetNum((int)score[2]);
    }

    // Update is called once per frame
    void Update()
    {
        bool checkr = false;
        bool checkb = false;
        bool checkg = false;
        switch (flug)
        {
            case 0:
               checkr = red.CheckNum();
               checkb = bull.CheckNum();
               checkg = green.CheckNum();
               if (checkr && checkb && checkg)
               {
                    flug = 1;
                    red.SetScore((int)(score[0] - (uint)gameScore.GetAnswerFalse1()) * 10);
                    bull.SetScore((int)(score[1] - (uint)gameScore.GetAnswerFalse2()) * 10);
                    green.SetScore((int)(score[2] - (uint)gameScore.GetAnswerFalse3()) * 10);
                }
                if (Input.GetMouseButtonDown(0))
                {
                    red.QuiqNum();
                    bull.QuiqNum();
                    green.QuiqNum();
                }
                break;
            case 1:
                checkr = red.CheckScore();
                checkb = bull.CheckScore();
                checkg = green.CheckScore();
                if (checkr && checkb && checkg)
                {
                    flug = 2;
                    Total.SetScore(totalscore);
                }
                if (Input.GetMouseButtonDown(0))
                {
                    red.QuiqScore();
                    bull.QuiqScore();
                    green.QuiqScore();
                }
                break;
            case 2:
                if (Total.GetMax())
                {
                    flug = 3;
                    Button.SetActive(true);
                }
                if (Input.GetMouseButtonDown(0))
                {
                    Total.SetQuiqScore();
                }
                break;
        }
        
    }

    public void DeleteScore()
    {
        Destroy(gameScore.gameObject);
    }
}
