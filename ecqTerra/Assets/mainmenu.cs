using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void Login()
    {
        SceneManager.LoadScene("LoginMenu");
    }

    public void offline()
    {
        SceneManager.LoadScene("offlineMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
 
}
