using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class offlinemenu : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("LoginMenu");
    }
 
}
