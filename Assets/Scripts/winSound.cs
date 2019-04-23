using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winSound : MonoBehaviour
{
    public AudioClip win;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.score >=100)
        {
            audioSource.PlayOneShot(win, 1.0F);
            enabled = false;
        }
    }
}
