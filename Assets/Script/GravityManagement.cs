using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GravityManagement : MonoBehaviour
{
    public bool gravityon = false;
    public float timebalanced;
    public int timelimit;
    public Text timerdisplay;
    public string leveltoload;
    public static GravityManagement Instance;

    private void Start()
    {
        Instance = this;
    }

    public void Gravityon()
    {
        if ((InventoryScript.Instance.amountwall == 0)&&(InventoryScript.Instance.amountroof == 0))
        gravityon = true;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (gravityon == true)
        {
            timebalanced += Time.deltaTime;
            timerdisplay.text = timebalanced.ToString();
            if (timebalanced > timelimit)
            {
                SceneManager.LoadScene(leveltoload);
            }
        }
    }
}
