using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public GameObject finalScoreDisplay;
    public static int scoreValue = 0;
    public int internalScore;

    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "" + scoreValue;
        finalScoreDisplay.GetComponent<Text>().text = "" + scoreValue;
    }
}
