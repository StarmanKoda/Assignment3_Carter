using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioSource Music;
    public AudioSource Spawnnoise;
    public float musictiming = 0;
    public static MusicScript Instance;
    public bool spawnnoise = false;
    public int musiclength;
    // Start is called before the first frame update
    void Start()
    {
        Music.Play();
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        musictiming += Time.deltaTime;

        if (musictiming > musiclength)
        {
            Music.Play();
        }
        if (spawnnoise == true)
        {
            Spawnnoise.Play();
            spawnnoise = false;
        }
    }
}