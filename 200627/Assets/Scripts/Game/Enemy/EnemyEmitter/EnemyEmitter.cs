using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmitter : MonoBehaviour
{

    [SerializeField] GameObject m_player;

    [SerializeField] GameObject m_enemyRedPrefabs;
    [SerializeField] GameObject m_enemyBluePrefabs;
    [SerializeField] GameObject m_enemyGreenPrefabs;
    [SerializeField] float m_radius;
    [SerializeField] float m_popTime;
    private float m_count;

    // Start is called before the first frame update
    void Start()
    {
        m_count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_count >= m_popTime * 60)
        {
            int value = Random.Range(0, 3);
            CreateEnemy(value);
            m_count = 0;
        }
        m_count++;
    }

    void CreateEnemy(int index)
    {
        float valueX = Random.Range(-1.0f, 1.0f);
        float valueY = Random.Range(-1.0f, 1.0f);
        Vector3 popPos = new Vector3(valueX * m_radius, valueY * m_radius, 0);
        GameObject obj = null;

        switch (index)
        {
            case 0:
                {
                    obj = Instantiate(m_enemyBluePrefabs, this.gameObject.transform);
                    break;
                }
            case 1:
                {
                    obj = Instantiate(m_enemyGreenPrefabs, this.gameObject.transform);
                    break;
                }
            case 2:
                {
                    obj = Instantiate(m_enemyRedPrefabs, this.gameObject.transform);
                    break;
                }
            default:
                {
                    break;
                }
        }


        obj.transform.position = popPos;
        obj.GetComponent<EnemyControl>().SetTargetPosObj(m_player);
    }
}
