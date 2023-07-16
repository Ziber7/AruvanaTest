using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void LoadS1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void LoadS2()
    {
        SceneManager.LoadScene("Scene2");
    }
}
