using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plsdontdestroy : MonoBehaviour
{
    // We have a class that we only want one of. This is the variable that we want. it will start by being null
    public static plsdontdestroy instance = null;

    private void Awake()
    {
        // if the instance is null, we do not have an object of this type yet
        if(instance == null)
        {
            // then we set this instance equal this 
            instance = this;
        // but if the instance is not null and not this
        } else if (instance != this)
        {
            //destroy
            Destroy(gameObject);
        }

        // when loading a new scene, so not destroy this object
        DontDestroyOnLoad(gameObject);

    }
}
