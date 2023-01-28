using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondspilprog : MonoBehaviour
{
    // Awake is called when the object is enabled
    private void Awake()
    {
        Debug.Log("Start");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Awake");
    }


    // Fixed update is called before update, at the same rate based on Delta Time 
    // physics 
    private void FixedUpdate()
    {
        Debug.Log("Fixed update");
    }

    // Update is called once per frame
    // game logic 
    void Update()
    {
        Debug.Log("Update");
    }

}
