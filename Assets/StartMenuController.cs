using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{

    public void HomePage(){
        Debug.Log("The button was pressed 2");
        SceneManager.LoadScene("Home Page");
    }
    public void PlayGame()
    {
      
        SceneManager.LoadScene("PlayScene"); 
    }

    public void OpenSelectMode()
    {
        SceneManager.LoadScene("SelectMode");
    }
    public void OpenShop()
    {        
        
        SceneManager.LoadScene("Shop"); 
    }
}
