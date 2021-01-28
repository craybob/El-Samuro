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
    public float collectSpeed = 0.5f;
    private int collectPower = 0;

    public bool killed = false;
    public Transform kill_position;
    public enemy enemy_script = FindObjectOfType<enemy>().GetComponent<enemy>();

    // Start is called before the first frame update
    void Start()
    {
        joybutton = FindObjectOfType<joyButton>();
        coinsText.text = "" + coins;
    }

    // Update is called once per frame
    void Update()
    {
        if (joybutton.pressed)
        {
            collectSpeed -= Time.deltaTime;
            killed = true;
            enemy_script = FindObjectOfType<enemy>().GetComponent<enemy>();
            enemy_script.enemyAttack();

            if (collectSpeed <= 0)
            {
                collectPower += 1;
                collectSpeed = 0.1f;
                damageText.text = "" + collectPower;
            }
        }

        else if (!joybutton.pressed)
        {
            if (killed == true)
            {
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

    public void destroy()
    {
        Destroy(gameObject);
    }
}
