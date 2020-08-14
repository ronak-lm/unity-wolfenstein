using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunAmmoPickup : MonoBehaviour
{
    public GameObject ammoClip;
    public AudioSource ammoPickupSound;

    void OnTriggerEnter(Collider other)
    {
        ammoClip.SetActive(false);
        GetComponent<BoxCollider>().enabled = false;
        ammoPickupSound.Play();

        GlobalAmmo.handgunAmmo += 10;
    }
}
