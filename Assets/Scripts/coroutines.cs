using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutines : MonoBehaviour
{
    private IEnumerator myCoroutineNumerator;

    // Start is called before the first frame update
    void Start()
    {
        myCoroutineNumerator = myCoroutine(1.0f);
        StartCoroutine(myCoroutineNumerator);
        Debug.Log("my coroutine is started");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            StopCoroutine(myCoroutineNumerator);
            Debug.Log("my coroutine is stopped");
        }
    }

    public IEnumerator myCoroutine(float waitTime) 
    {
        while (true) 
        {
            yield return new WaitForSeconds(waitTime);
            Debug.Log("in coroutine");
        }
    }
}

