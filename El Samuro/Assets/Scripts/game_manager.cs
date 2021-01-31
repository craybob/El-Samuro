﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    private player playerScript;

    public Animator transition_anim;
    public GameObject transition;

    public GameObject gameOverPanel;

    public Transform player_script;
    // Start is called before the first frame update
    void Start()
    {
        transition_anim.SetBool("light", true);
    }

    // Update is called once per frame
    void Update()
    {
        playerScript = FindObjectOfType<player>();
        if (playerScript == null)
        {
            gameOverMenu();
        }
    }

    void gameOverMenu()
    {
        SceneManager.LoadScene(0);
        gameOverPanel.SetActive(true);
    }

    public void replayScene()
    {
        SceneManager.LoadScene(0);
    }
    
    // transition To next LVL
    public void switchOff()
    {
        transition_anim.SetBool("light", false);
        Invoke("switchOn", 1f);
    }

    void switchOn()
    {
        player_script.position = new Vector3(-0.9f, -0.01f, 0f);
        transition_anim.SetBool("light", true);
    }


}
