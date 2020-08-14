using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunPickup : MonoBehaviour
{
    public GameObject realHandgun;
    public GameObject fakeHandgun;
    public AudioSource handgunPickupSound;

    void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true);
        fakeHandgun.SetActive(false);
        handgunPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
    }
}
