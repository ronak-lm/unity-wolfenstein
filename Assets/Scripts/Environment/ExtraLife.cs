using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    public AudioSource lifePickupSound;

    void OnTriggerEnter(Collider other)
    {
        GlobalLives.livesValue += 1;
        lifePickupSound.Play();
        this.gameObject.SetActive(false);
    }
}
