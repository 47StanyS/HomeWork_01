using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOn : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        Debug.Log("Dmage inflicted " + other.gameObject.name + "Good job");
    }
}
