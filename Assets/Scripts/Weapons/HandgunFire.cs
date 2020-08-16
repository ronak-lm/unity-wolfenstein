using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFireSound;
    public AudioSource gunEmptySound;

    public float targetDistance;
    public int damageAmount = 5;

    private bool isFiring;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.handgunAmmo <= 0)
            {
                gunEmptySound.Play();
            }
            else if (!isFiring)
            {
                StartCoroutine(FireHandgun());
            }
        }
    }

    IEnumerator FireHandgun()
    {
        isFiring = true;
        GlobalAmmo.handgunAmmo--;

        RaycastHit theShot;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }

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
