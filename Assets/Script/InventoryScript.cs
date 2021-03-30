using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    public int amountroof;
    public int amountwall;
    public Text roofdisplay;
    public Text walldisplay;
    public static InventoryScript Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        roofdisplay.text = amountroof.ToString();
        walldisplay.text = amountwall.ToString();
    }
}
