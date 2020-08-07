using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLanguageChosen : MonoBehaviour
{
    public void GTCMLanguageChosen()
    {
        SceneManager.LoadScene("CM Language Chosen");
    }

    public void GTMPLanguageChosen()
    {
        SceneManager.LoadScene("MP Language Chosen");
    }
}
