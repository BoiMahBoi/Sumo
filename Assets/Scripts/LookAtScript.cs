using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{

    public Transform enemyTransform;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(enemyTransform);
    }
}
