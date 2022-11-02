using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    // private float xPos = Random.Range(-5f, 5f);
    // private float yPos = Random.Range(-10, 0);
    // Start is called before the first frame update

    
    public GameObject[] gameObjects;
    private Vector3 spawnPos = new Vector3(5, 6f, -10);
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            spawnPos = new Vector3(Random.Range(-5, 5), 6f, Random.Range(-10, 0));
            GameObject olusanKure= Instantiate(gameObjects[Random.Range(0, gameObjects.Length)], spawnPos, Quaternion.identity);
            Color renk1 = new Color();
            renk1.r = Random.Range(0, 5);
            renk1.b = Random.Range(0, 5);
            renk1.g = Random.Range(0, 5);
            olusanKure.transform.localScale = new Vector3(Random.Range(0.1f, 2), Random.Range(0.1f, 2), Random.Range(0.1f, 2));
            olusanKure.GetComponent<Renderer>().material.color = renk1;



        }
    }
}
