using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasUIFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}