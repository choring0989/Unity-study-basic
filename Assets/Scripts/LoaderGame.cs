using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderGame : MonoBehaviour
{
    public string sceneToLoad;

    public void LoadGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
