using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarField : MonoBehaviour
{
    private GameController gameControllerObj;
    private ParticleSystem ps;
    private float hSliderValue = 1.0F;

    // Start is called before the first frame update
    void Start()
    {
        gameControllerObj = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var main = ps.main;
        main.simulationSpeed = hSliderValue;

        if(GameController.score >= 100)
        {
            if(hSliderValue <=50)
            {
                hSliderValue = 50;
            }
        }
    }
}
