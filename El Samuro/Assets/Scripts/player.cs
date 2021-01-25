using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    protected joyButton joybutton;
    public int coins;
    public Text damageText;

    // Start is called before the first frame update
    void Start()
    {
        joybutton = FindObjectOfType<joyButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (joybutton.pressed)
        {
            for (int i = 0; i < 100; i++)
            {
                damageText.text = "" + i;
                coins += i;
            }
        }
    }
}
