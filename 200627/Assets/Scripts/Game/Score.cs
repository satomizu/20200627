using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int m_Total = 0;
    private int m_HighTotal = 0;

    public int m_AnswerTrue1 = 0;
    public int m_AnswerTrue2 = 0;
    public int m_AnswerTrue3 = 0;
    public int m_AnswerFalse1 = 0;
    public int m_AnswerFalse2 = 0;
    public int m_AnswerFalse3 = 0;


    public int TotalScore { get { return m_Total; } }
    public int TotalHighScore { get { return m_HighTotal; } }
    public int Answer1 { get { return m_AnswerTrue1 - m_AnswerFalse1; } }
    public int Answer2 { get { return m_AnswerTrue2 - m_AnswerFalse1; } }
    public int Answer3 { get { return m_AnswerTrue3 - m_AnswerFalse1; } }

    public int GetAnswerTrue1() { return m_AnswerTrue1; }
    public int GetAnswerTrue2() { return m_AnswerTrue2; }
    public int GetAnswerTrue3() { return m_AnswerTrue3; }
    public int GetAnswerFalse1() { return m_AnswerFalse1; }
    public int GetAnswerFalse2() { return m_AnswerFalse2; }
    public int GetAnswerFalse3() { return m_AnswerFalse3; }

    public void AddAnswerTrue1() { m_AnswerTrue1++; }
    public void AddAnswerTrue2() { m_AnswerTrue2++; }
    public void AddAnswerTrue3() { m_AnswerTrue3++; }
    public void AddAnswerFalse1() { m_AnswerFalse1++; }
    public void AddAnswerFalse2() { m_AnswerFalse2++; }
    public void AddAnswerFalse3() { m_AnswerFalse3++; }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        m_Total = (m_AnswerTrue1 + m_AnswerTrue2 + m_AnswerTrue3 
                   - m_AnswerFalse1 - m_AnswerFalse2 - m_AnswerFalse3) * 10;

        if (m_Total > m_HighTotal)
        {
            m_HighTotal = m_Total;
        }

    }
}
