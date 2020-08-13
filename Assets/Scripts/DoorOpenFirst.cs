using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorClose");
        GetComponent<BoxCollider>().enabled = true;
    }
}
