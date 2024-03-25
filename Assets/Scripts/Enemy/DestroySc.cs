using UnityEngine;

public class DestroySc : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
    }
}
