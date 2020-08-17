using UnityEngine;

public class Floor001A : MonoBehaviour
{
    public GameObject moveableWall;

    void OnTriggerEnter(Collider other)
    {
        moveableWall.GetComponent<Animator>().enabled = true;
        GetComponent<BoxCollider>().enabled = false;
    }
}
