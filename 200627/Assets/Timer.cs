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
        countTime -= Time.deltaTime; //�X�^�[�g���Ă���̕b�����i�[
        GetComponent<Text>().text = countTime.ToString("F2"); //����2���ɂ��ĕ\��
        if (countTime <= 0) SceneManager.LoadScene("Result");
    }
}