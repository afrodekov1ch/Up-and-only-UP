using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopterPlatform : MonoBehaviour
{
    public GameObject copterHelm;
    [SerializeField] private PlayerMovement pl;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Copter")
        {
            GetCopter();
            Invoke("NotCopter", 4);
        }
    }

    private void GetCopter()
    {
        copterHelm.SetActive(true);
        pl._jumpForce = 20;
    }
    private void NotCopter()
    {
        copterHelm.SetActive(false);
        pl._jumpForce = 10;
    }
}
