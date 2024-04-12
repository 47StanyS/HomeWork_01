using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LokationDraft : MonoBehaviour
{
    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private GameObject prefab3;

    [SerializeField] private GameObject playerPrefab;

    [SerializeField] private GameObject groundPrefab;
    [SerializeField] private GameObject groundFurniturePrefab;
    void Start()
    {
        //PrefabUtility.GetPrefabObject 

        // player.transform.position = new Vector3(0,5,0);

        //GameObject player = new GameObject ("Player", typeof(Rigidbody), typeof(BoxCollider));

        Instantiate(playerPrefab, new Vector3(0, 10, 0), Quaternion.identity);

        GameObject furniturePrefab = Instantiate(groundFurniturePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        furniturePrefab.AddComponent<BoxCollider>();
        furniturePrefab.AddComponent<CollisionOn>();
        furniturePrefab.AddComponent<DestroyGround>();

        //Instantiate(groundPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        //groundPrefab.transform.eulerAngles = new Vector3(-90,0,0);

        // GameObject ground = new GameObject ("Ground", typeof (Rigidbody), typeof(BoxCollider));
        // ground.transform.position = new Vector3(0,0,0);

        // GameObject enemy = new GameObject ("Enemy", typeof(Rigidbody),typeof(BoxCollider));
        // enemy.transform.position = new Vector3(0,15,0);

        // transform.position = new Vector3(10, 15, 0);

        GameObject groundInstance = Instantiate(groundPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        groundInstance.transform.eulerAngles = new Vector3(0, 0, 0);

        //groundInstance.AddComponent<Rigidbody>();
        //Rigidbody rigidbody = groundInstance.AddComponent <Rigidbody>();
        //rigidbody.useGravity = false;
        //rigidbody.isKinematic = true;

        groundInstance.AddComponent<BoxCollider>();
        groundInstance.AddComponent<CollisionOn>();
        groundInstance.AddComponent<DestroyGround>();

        for (var i = 0; i < 10; i++)
        {
            float randomX = Random.Range(-4.0f, 4.0f);
            int randomY = Random.Range(15, 70);

            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

            Instantiate(prefab1, spawnPosition, Quaternion.identity);
            Instantiate(prefab2, spawnPosition, Quaternion.identity);
            Instantiate(prefab3, spawnPosition, Quaternion.identity);
        }

    }

}
