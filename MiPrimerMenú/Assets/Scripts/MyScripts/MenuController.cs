using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartLogin() {

        SceneManager.LoadScene("Menu 3D");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
