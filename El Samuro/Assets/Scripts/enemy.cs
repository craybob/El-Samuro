using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int minTime;
    public int maxTime;
    public float typeOfEnemy;
    public bool alive = true;
    [HideInInspector]
    public player playerScript;
    public enemy_spawn spawnScript;
    game_manager manager_script;


    private void Awake()
    {
        playerScript = FindObjectOfType<player>().GetComponent<player>();
        playerScript.enemyDetect();


        spawnScript = FindObjectOfType<enemy_spawn>().GetComponent<enemy_spawn>();
        manager_script = FindObjectOfType<game_manager>().GetComponent<game_manager>();
    }

    void Update()
    {


        if (alive == false)
        {
            spawnScript.time2spawn();

            manager_script.switchOff();
            Destroy(gameObject);
        }
    }


    public void enemyAttack()
    {
        int time2attack = Random.Range(minTime,maxTime);
        Invoke("attack", time2attack);
    }

    void attack()
    {
        
        transform.position = new Vector2(-1.2f, -0.01f);
        playerScript.destroy();
    }
}
