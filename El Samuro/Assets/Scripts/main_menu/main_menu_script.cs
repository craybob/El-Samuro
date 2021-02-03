using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_script : MonoBehaviour
{
    //BUTTON SCRIPTS
    public void Play_button()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit_button()
    {
        Application.Quit();
    }
}
