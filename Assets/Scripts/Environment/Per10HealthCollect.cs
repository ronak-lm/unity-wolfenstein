using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Per10HealthCollect : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (GlobalHealth.healthValue >= 91)
        {
            GlobalHealth.healthValue = 100;
        }
        else
        {
            GlobalHealth.healthValue += 10;
        }
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
