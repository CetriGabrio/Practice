using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Bump");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Wrum");
    }

}
