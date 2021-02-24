using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{
    private player playerScript;

    public Animator transition_anim;
    public GameObject transition;

    public GameObject gameOverPanel = null;

    public Transform player_script;
    public bool player_alive = true;

    public AudioClip[] game_music;
    public AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        transition_anim.SetBool("light", true);
    }

    void Awake()
    {
        musicSource.clip = game_music[0];
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (player_alive == false)
        {
            gameOverMenu();
        }
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

    //GAMEOVER MENU
    void gameOverMenu()
    {
        gameOverPanel.SetActive(true);
    }

    public void replayScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void main_menu_button()
    {
        SceneManager.LoadScene(0);
    }


}
