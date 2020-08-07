using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{
    public void BackToMenus()
    {
        SceneManager.LoadScene("Menus");
    }
    
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
