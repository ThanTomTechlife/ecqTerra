
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loginmenu : MonoBehaviour
{

    public InputField usernameField;
    public InputField passwordField;
        public void CallLogin()
    {
        StartCoroutine(LoginUser());
    }
       IEnumerator LoginUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", usernameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://Localhost/ecq/Login.php", form);
        yield return www;

        if (www.text[0] == '0')
        {
            DBManager.username = usernameField.text;
            DBManager.password = passwordField.text;
            SceneManager.LoadScene("Dashboard");
        }
        else
        {
            Debug.Log("User login failed. Error #" + www.text);


        }
        

    }


    public void loginuser()
    {   
        if (usernameField.text != "" && passwordField.text != "")
        {
            SceneManager.LoadScene("Dashboard");
        }
        else
        {
            Debug.Log("Please enter username and password");
        }
        



    }




   public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }




}
