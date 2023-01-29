using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getcomponent : MonoBehaviour
{
    public AudioSource myMusicPlayer;

    public Transform playerTransform;

    public GameObject myObj;

    // Start is called before the first frame update
    void Start()
    {
        // By name 
        myMusicPlayer = GameObject.Find("myMusicPlayerObject").GetComponent<AudioSource>();

        myMusicPlayer.Play();

        // By tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        playerTransform.localScale = Vector3.one;

        // Direct 
        myObj.GetComponent<Rigidbody>().isKinematic = false;

    }

    public IEnumerator myCoroutine() 
    {
        yield return new WaitForSeconds(4);


    }

}


