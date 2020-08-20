using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completeLevel;
    public GameObject thePlayer;
    public GameObject timer;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        completeLevel.SetActive(true);
        timer.SetActive(false);
    }
}
