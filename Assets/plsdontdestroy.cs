using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plsdontdestroy : MonoBehaviour
{
    public static plsdontdestroy instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }
}
