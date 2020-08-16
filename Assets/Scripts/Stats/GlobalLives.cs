using UnityEngine;
using UnityEngine.UI;

public class GlobalLives : MonoBehaviour
{
    public GameObject livesDisplay;
    public static int livesValue = 3;
    public int internalLives;

    void Update()
    {
        internalLives = livesValue;
        livesDisplay.GetComponent<Text>().text = "" + livesValue;
    }
}
