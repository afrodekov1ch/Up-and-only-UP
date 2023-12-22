using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrujinPlatform : MonoBehaviour
{
    [SerializeField] private PlayerMovement pl;

    private void Start()
    {
        pl = GetComponent<PlayerMovement>();

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Prujin")
        {
            pl._jumpForce = 15;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Prujin")
        {
            pl._jumpForce = 10;
        }
    }
   
}
