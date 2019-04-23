using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BGScroller : MonoBehaviour
{

    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    
    void Start()
    {
        startPosition = transform.position;
        GameObject points = GameObject.Find("GameController");
        GameController gameController = points.GetComponent<GameController>();
        
    }

    
    void Update()
    {
        float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;

        if(GameController.score >=100)
        {
            newPosition = Mathf.Repeat(Time.time * -10, tileSizeZ);
            transform.position = startPosition + Vector3.forward * newPosition;
        }
        
    }
}
