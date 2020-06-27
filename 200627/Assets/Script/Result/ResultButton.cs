using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultButton : MonoBehaviour
{
    [SerializeField]
    private string GameScene = "Game";
    [SerializeField]
    private string TitelScene = "Titel";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onButtonRestart()
    {
        SceneManager.LoadScene(GameScene);
    }

    public void onButtonBackTitel()
    {
        SceneManager.LoadScene(TitelScene);
    }
}
