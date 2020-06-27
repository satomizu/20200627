using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    [SerializeField] float m_deleteTime;
    private float m_count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDelete()) Destroy(this.gameObject);
        m_count++;
    }

    bool IsDelete() { return m_count >= m_deleteTime * 60; }
}
