using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform sataliteSpawnParent;
    public GameObject satalitePrefab;
    public int spawnedAmount = 0;

    private void Awake()
    {
        spawnedAmount = ES3.Load<int>("spawnedAmount", 0);
    }
    void Start()
    {
        for (int i = 0; i < spawnedAmount; i++)
        {
            SpawnObjekt(satalitePrefab);
        }
    }
    public void SpawnObjekt(GameObject objectToSpawn)
    {



        if (objectToSpawn != null)
        {


            float rotationY; // 0 -> 360
            float rotationX; // -90 -> 90


            rotationY = Random.Range(0, 150);
            print(rotationY);
            rotationX = Random.Range(-45, 45);




            var spawnedObject = Instantiate(objectToSpawn, new Vector3(), Quaternion.identity, sataliteSpawnParent);
            spawnedObject.transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
            spawnedAmount++;
            ES3.Save<int>("spawnedAmount", spawnedAmount);




        }

    }
}
