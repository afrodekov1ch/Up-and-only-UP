using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlatform : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < -9f)
        {
            Reload();
        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Death")
        {
            Reload();
        }
    }
    private void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
