using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondspilprog : MonoBehaviour
{
    // Awake is called when script is being loaded
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }


    // Fixed update is called every fixed frame-rate frame. 
    // ex: runs a specific number of frames in second, which is set in editor -
    // no matter of your computer editor.
    // physics 
    private void FixedUpdate()
    {
        Debug.Log("Fixed update");
    }

    // Update is called once per frame
    // Ex: fps on pc 30, 30 fps in second in the game. 
    // game logic 
    void Update()
    {
        Debug.Log("Update");
    }

}
