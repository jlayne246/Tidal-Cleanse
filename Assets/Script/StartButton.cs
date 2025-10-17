using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void taskOnClick()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene("SampleScene");
    }
}
