using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public Transform[] spawnPoints;
    public GameObject[] enemies;

    float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float minTimeBtwSpawns;
    public float decrease;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawns <= 0) 
        {
            Transform randSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject newEnemy = enemies[Random.Range(0, enemies.Length)];
            Instantiate(newEnemy, randSpawnPoint.position, Quaternion.identity);
            if (startTimeBtwSpawns > minTimeBtwSpawns)
                {
                    startTimeBtwSpawns -= decrease;
                }
                timeBtwSpawns = startTimeBtwSpawns;
        } 
        else 
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
