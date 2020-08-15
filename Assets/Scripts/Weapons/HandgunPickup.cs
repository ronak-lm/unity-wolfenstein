using UnityEngine;
using UnityEngine.UI;

public class HandgunPickup : MonoBehaviour
{
    public GameObject realHandgun;
    public GameObject fakeHandgun;
    public AudioSource handgunPickupSound;
    public GameObject notificationDisplay;

    void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true);
        fakeHandgun.SetActive(false);
        handgunPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;

        notificationDisplay.SetActive(false);
        notificationDisplay.GetComponent<Text>().text = "HANDGUN";
        notificationDisplay.SetActive(true);
    }
}
