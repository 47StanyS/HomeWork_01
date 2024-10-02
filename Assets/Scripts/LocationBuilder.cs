using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class LocationBuilder : MonoBehaviour
{
    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private GameObject prefab3;

   // [SerializeField] private GameObject playerPrefab;
   //
   // [SerializeField] private GameObject groundPrefab;
   // [SerializeField] private GameObject groundFurniturePrefab;
    void Start()
    {
      //  Instantiate(playerPrefab,new Vector3 (0, 10, 0), Quaternion.identity);
      //
      //  GameObject furniturePrefab = Instantiate(groundFurniturePrefab, new Vector3(0,0,0) , Quaternion.identity);
      //  furniturePrefab.AddComponent<BoxCollider>();
      //  furniturePrefab.AddComponent<CollisionOn>();
      //  furniturePrefab.AddComponent<DestroyGround>();
      //
      //  GameObject groundInstance = Instantiate(groundPrefab, new Vector3(0, 0, 0), Quaternion.identity);
      //  groundInstance.transform.eulerAngles = new Vector3(0, 0, 0);
      //  groundInstance.AddComponent<BoxCollider>();
      //  groundInstance.AddComponent<CollisionOn>();
      //  groundInstance.AddComponent<DestroyGround>();

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
