using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject theEnemy;

    public string hitTag;
    public bool lookingAtPlayer = false;

    public AudioSource fireSound;
    public bool isFiring = false;

    public float fireRate = 1f;

    public int genHurt;
    public AudioSource[] hurtSound;

    public GameObject hurtFlash;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            hitTag = hit.transform.tag;
        }
        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire());
        }
        if (hitTag != "Player")
        {
            theEnemy.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        theEnemy.GetComponent<Animator>().Play("FirePistol", -1, 0);
        theEnemy.GetComponent<Animator>().Play("FirePistol");
        fireSound.Play();
        lookingAtPlayer = true;

        GlobalHealth.healthValue -= 5;

        hurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        hurtFlash.SetActive(false);
        genHurt = Random.Range(0, 3);
        hurtSound[genHurt].Play();

        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}
