using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverSound : MonoBehaviour
{
    public AudioClip lose;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.lives <=0)
        {
            audioSource.PlayOneShot(lose, 2.5F);
            enabled = false;
        }
    }
}
