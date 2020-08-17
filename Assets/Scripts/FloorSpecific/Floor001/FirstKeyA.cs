using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKeyA : MonoBehaviour
{
    public GameObject theKey;
    public GameObject keyUI;
    public GameObject lockedTrigger;

    void OnTriggerEnter(Collider other)
    {
        theKey.SetActive(false);
        keyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        GetComponent<BoxCollider>().enabled = false;
    }
}
