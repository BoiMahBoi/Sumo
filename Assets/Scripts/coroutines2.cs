using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutines2 : MonoBehaviour, ImyInterface
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coroutineA());
    }

    IEnumerator coroutineA() 
    {
        yield return new WaitForSeconds(1.0f);
        Debug.Log("CoroutineA started " + Time.time);

        yield return new WaitForSeconds(1.0f);
        Coroutine b = StartCoroutine(coroutineB());

        yield return new WaitForSeconds(3.0f);
        Debug.Log("CoroutineA() finished " + Time.time);

        StopCoroutine(b);
        yield return null;
    }

    IEnumerator coroutineB() 
    {
        float f = 0.0f;
        float start = Time.time;

        Debug.Log("CoroutineB started " + start);

        while(f < 10.0f) 
        {
            Debug.Log("coroutineB + " + f);
            yield return new WaitForSeconds(1.0f);
            f++; 
        }
    }
}
