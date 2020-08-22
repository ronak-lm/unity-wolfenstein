using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject theEnemy;
    public GameObject enemyAI;
    public GameObject hurtFlash;
    public int enemyHealth = 20;
    public bool enemyDead = false;

    void DamageEnemy(int damageAmount)
    {
        if (enemyAI.activeInHierarchy)
        {
            enemyHealth -= damageAmount;
            if (enemyHealth <= 0)
            {
                enemyDead = true;
                theEnemy.GetComponent<Animator>().Play("Death");
                theEnemy.GetComponent<LookPlayer>().enabled = false;
                enemyAI.SetActive(false);
                hurtFlash.SetActive(false);

                GlobalScore.scoreValue += 100;
                GlobalComplete.enemyCount++;
            }
        }
    }
}
