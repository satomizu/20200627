using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    float countTime = 30;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime; //スタートしてからの秒数を格納
        GetComponent<Text>().text = countTime.ToString("F2"); //小数2桁にして表示
        if (countTime <= 0) SceneManager.LoadScene("Result");
    }
}