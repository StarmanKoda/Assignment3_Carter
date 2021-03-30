using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public string keyName;
    public GameObject menu;
    bool isPaused = false;
    public string leveltoreload;
    public string homemenu;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void Restart()
    {
        SceneManager.LoadScene(leveltoreload);
    }
    public void Menu()
    {
        SceneManager.LoadScene(homemenu);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(keyName))
        {
            menu.SetActive(!menu.activeInHierarchy);
            isPaused = !isPaused;

            if (isPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}