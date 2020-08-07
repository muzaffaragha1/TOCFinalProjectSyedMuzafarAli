using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void QuitGameFunction()
    {
        SceneManager.LoadScene("ML Agents");
    }
    
    public void BackToComputationalModels()
    {
        SceneManager.LoadScene("Computational Models");
    }
    
    public void BackToMatchPar()
    {
        SceneManager.LoadScene("Match Par");
    }


}
