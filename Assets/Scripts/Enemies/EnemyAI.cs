using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theEnemy;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            hitTag = hit.transform.tag;
        }
        if (hitTag == "Player")
        {
            theEnemy.GetComponent<Animator>().Play("FirePistol");
            lookingAtPlayer = true;
        }
        else
        {
            theEnemy.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }
    }
}
