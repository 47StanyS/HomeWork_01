using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private GameObject prefab3;
    void Start()
    {
        // GameObject player = new GameObject ("Player", typeof(Rigidbody), typeof(BoxCollider));

        // player.transform.position = new Vector3(0,5,0);

        // GameObject ground = new GameObject ("Ground", typeof (Rigidbody), typeof(BoxCollider));
        // ground.transform.position = new Vector3(0,0,0);

        // GameObject enemy = new GameObject ("Enemy", typeof(Rigidbody),typeof(BoxCollider));
        // enemy.transform.position = new Vector3(0,15,0);


        // transform.position = new Vector3(10, 15, 0);

        for (var i = 0; i < 10; i++)
        {
            float randomX = Random.Range(-4.0f,4.0f);
            int randomY = Random.Range(10, 60);

            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

            Instantiate(prefab1, spawnPosition, Quaternion.identity);
            Instantiate(prefab2, spawnPosition, Quaternion.identity);
            Instantiate(prefab3, spawnPosition, Quaternion.identity);
        }
    }

}
