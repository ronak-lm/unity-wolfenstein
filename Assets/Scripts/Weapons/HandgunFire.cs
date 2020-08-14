using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFireSound;

    private bool isFiring;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isFiring)
        {
            StartCoroutine(FireHandgun());
        }
    }

    IEnumerator FireHandgun()
    {
        isFiring = true;
        theGun.GetComponent<Animator>().Play("HandgunFire");
        muzzleFlash.SetActive(true);
        gunFireSound.Play();

        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);

        yield return new WaitForSeconds(0.25f);
        theGun.GetComponent<Animator>().Play("Default");
        isFiring = false;
    }
}
