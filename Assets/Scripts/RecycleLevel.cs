using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour
{
    public GameObject gameOver;
    void Start()
    {
        GlobalLives.livesValue--;
        if (GlobalLives.livesValue <= 0)
        {
            gameOver.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Level001");
        }
    }
}
