using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollect : MonoBehaviour
{
    public GameObject goldIngots;
    public AudioSource collectSound;
    public GameObject notificationDisplay;

    void OnTriggerEnter(Collider other)
    {
        GlobalScore.scoreValue += 500;
        GlobalComplete.treasureCount++;

        goldIngots.SetActive(false);
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false;

        notificationDisplay.SetActive(false);
        notificationDisplay.GetComponent<Text>().text = "GOLD INGOTS";
        notificationDisplay.SetActive(true);
    }
}
