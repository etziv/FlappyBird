using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource lostSound;
    AudioSource main;
    public GameObject maincam;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        main = maincam.GetComponent<AudioSource>();
        lostSound = lostSound.GetComponent<AudioSource>();
        main.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver.activeSelf && main.isPlaying){
            main.Stop();
            lostSound.Play();
        }
        if(!gameOver.activeSelf){
            lostSound.Stop();
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
