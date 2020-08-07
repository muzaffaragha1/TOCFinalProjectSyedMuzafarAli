using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    
    public void GoToLearnedItems()
    {
        SceneManager.LoadScene("Learned Items");
    }
    
    public void GoToInstructorsWebsite()
    {
        SceneManager.LoadScene("Link To Instructor Website");
    }
    
    public void Quit()
    {
        // Add code for quit application
    }


}
