using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject PrefabEnemy;
    public Transform spawn;
    public GameManagerJuego gameManager;
    void Start()
    {
        Invoke("CreateEnemy", 2.5f);
    }

    void CreateEnemy()
    {
        float random = Random.Range(-8.88f,8.88f);
        Vector2 spawnPosition = new Vector2(random, 5.66f);

        GameObject enemy =Instantiate(PrefabEnemy, spawnPosition, transform.rotation);
        enemy.GetComponent<NaveControl>().SetGameManager(gameManager);
        Invoke("CreateEnemy", 2.5f);
    }
}
