using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour
{
    public GameObject[] enemy;
    public bool scan = true;
    public enemy enemy_alive;

    // Update is called once per frame
    void Update()
    {

        if (scan == true)
        {
            enemy_alive = FindObjectOfType<enemy>();
            if (enemy_alive == null)
            {
                spawnEnemy();
            }
        }
    }

    public void time2spawn()
    {
        Invoke("spawnEnemy", 0.5f);
    }

    void spawnEnemy()
    {
        int randomEnemy = Random.Range(0, enemy.Length);
        Instantiate(enemy[randomEnemy], transform.position, Quaternion.identity);
        scan = false;
    }
}
