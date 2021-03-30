using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    public string leveltoload;

    void OnCollisionEnter(Collision coll)
    {
        SceneManager.LoadScene(leveltoload);
    }
}
