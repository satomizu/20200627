using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultHiScore : MonoBehaviour
{
    [SerializeField]
    private Text totalscore = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int Tscore = int.Parse(totalscore.text);
        int Hscore = int.Parse(GetComponent<Text>().text);
        if(Hscore < Tscore)
        {
            GetComponent<Text>().text = Tscore.ToString();
        }
    }
}
