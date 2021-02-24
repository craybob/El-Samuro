using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    protected joyButton joybutton;
    public int coins;
    public Text damageText;
    public Text coinsText;
    public float collectSpeed = 0.1f;
    private int collectPower = 0;

    public bool killed = false;
    public Transform kill_position;
    public enemy enemy_script;

    public AudioClip[] player_sound;


    game_manager gameScript;



    // Start is called before the first frame update
    void Start()
    {
        joybutton = FindObjectOfType<joyButton>();
        coinsText.text = "" + coins;

        gameScript = FindObjectOfType<game_manager>().GetComponent<game_manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (joybutton.pressed)
        {
            collectSpeed -= Time.deltaTime;
            killed = true;
            enemy_script.enemyAttack();
            collectPower += 1;
            damageText.text = "" + collectPower;
            
        }

        else if (!joybutton.pressed)
        {
            if (killed == true)
            {
                mySoundManager.instance.Play(player_sound[0]);
                transform.position = kill_position.position;
                enemy_script.alive = false;
                killed = false;
            }
            coins += collectPower;
            collectPower = 0;
            coinsText.text = "" + coins;
            damageText.text = "" + collectPower;
        }

    }

    public void enemyDetect()
    {
        enemy_script = FindObjectOfType<enemy>().GetComponent<enemy>();
    }

    public void destroy()
    {
        gameScript.player_alive = false;
        Destroy(gameObject);
    }
}
