using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;

    void Start()
    {
        //Esta funcion llama al SpawnObstacle tras 0.5 segundos que empieza el juego, y que se repita cada 5 segundos
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

    //Con esto hacemos que el obstaculo se instancie a una altura aleatoria a 50 metros más adelante que el anterior
    public Vector3 RandomSpawnPosition()
    {
        return new Vector3(0, randomY, spawnPos.z + 50);
    }

    //Esto hace que aparezcan obstaculos en la escena de forma aleatoria 
    public void SpawnObstacle()
    {
        int randomY = Random.Range(-10,10);
        spawnPos = RandomSpawnPosition();
        Instantiate(obstaclePrefab, spawnPos,
        obstaclePrefab.transform.rotation);
    }
}
