using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnCooldown = 1.0f;
    private float lastSpawnTime;
    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastSpawnTime >= spawnCooldown)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastSpawnTime = Time.time;
            }
        }
    }
}
