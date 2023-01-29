using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutine3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(doSomething1());
        StartCoroutine(doSomething2());  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            StopAllCoroutines();
            Debug.Log("my coroutines have stopped + " + Time.time);
        } 
    }

    IEnumerator doSomething1() 
    {
        while (true) 
        {
            Debug.Log("doing something fun in coroutine 1");
            yield return new WaitForSeconds(1.0f);
        }
    }

    IEnumerator doSomething2() 
    {
        while (true)
        {
            Debug.Log("doing something for you in coroutine 2");
            yield return new WaitForSeconds(2.0f);
        }
    }

}
