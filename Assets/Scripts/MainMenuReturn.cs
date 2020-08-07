using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuReturn : MonoBehaviour
{
    public void ReturnToMenus()
    {
        SceneManager.LoadScene("Menus");
    }
    
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    
    public void ReturnToComputationalModels()
    {
        SceneManager.LoadScene("Computational Models");
    }
    
    public void ReturnToMatchPar()
    {
        SceneManager.LoadScene("Match Par");
    }
}
