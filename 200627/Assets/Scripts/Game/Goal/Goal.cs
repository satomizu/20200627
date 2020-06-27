using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //�G�l�~�[�^�C�v�@�e�F�������Ă���
    [SerializeField] Score m_score;
    // �����Ƀ^�C�v�ϐ���ǉ�
    [SerializeField] private EnemyControl.Index m_index;
    //����
    private int answerNum;
    //�s����
    private int incorrectAnswerNum;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Judgement(bool isAnswer)
    {
        if (isAnswer)
        {
            answerNum++;

            switch (m_index)
            {
                case EnemyControl.Index.Red:
                    m_score.AddAnswerTrue1();
                    break;
                case EnemyControl.Index.Blue:
                    m_score.AddAnswerTrue2();
                    break;
                case EnemyControl.Index.Green:
                    m_score.AddAnswerTrue3();
                    break;
                default:
                    break;
            }
        }
        else
        {
            incorrectAnswerNum++;

            switch (m_index)
            {
                case EnemyControl.Index.Red:
                    m_score.AddAnswerFalse1();
                    break;
                case EnemyControl.Index.Blue:
                    m_score.AddAnswerFalse2();
                    break;
                case EnemyControl.Index.Green:
                    m_score.AddAnswerFalse3();
                    break;
                default:
                    break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            //collision�̃^�O���G�l�~�[��������
            bool isAnswer = false;
            Debug.Log("Fight");
            if(collision.gameObject.tag == "Enemy")
            {
                GameObject hitObj = collision.gameObject;
                EnemyControl.Index index = hitObj.GetComponent<EnemyControl>().GetType();

                if(m_index == index)
                {
                    isAnswer = true;
                }
                else
                {
                    isAnswer = false;
                }
                Judgement(isAnswer);
            }

        }
    }
    private int GetAnswerNum()
    {
        return answerNum;
    }
    private int GetincorrectAnswerNum()
    {
        return incorrectAnswerNum;
    }
}
