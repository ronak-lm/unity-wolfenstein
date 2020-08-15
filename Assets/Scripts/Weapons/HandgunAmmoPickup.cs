using UnityEngine;
using UnityEngine.UI;

public class HandgunAmmoPickup : MonoBehaviour
{
    public GameObject ammoClip;
    public AudioSource ammoPickupSound;
    public GameObject notificationDisplay;

    void OnTriggerEnter(Collider other)
    {
        ammoClip.SetActive(false);
        GetComponent<BoxCollider>().enabled = false;

        ammoPickupSound.Play();
        GlobalAmmo.handgunAmmo += 10;

        notificationDisplay.SetActive(false);
        notificationDisplay.GetComponent<Text>().text = "CLIP OF BULLETS";
        notificationDisplay.SetActive(true);
    }
}
