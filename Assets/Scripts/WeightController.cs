using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightController : MonoBehaviour
{
    public float cookieCalories;
    public float startWeight;
    public float minWeight;
    public float maxWeight;
    [HideInInspector]
    public float currentWeight;

    [Header("Audio")]
    public AudioClip slurpSound;
    public AudioClip ewSound;

    // Start is called before the first frame update
    void Start()
    {
        currentWeight = startWeight;
    }

    private void FixedUpdate()
    {
        gameObject.transform.localScale = new Vector3(currentWeight, currentWeight, 1);

        if(currentWeight > minWeight)
        {
            currentWeight -= 0.1f * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cookie"))
        {
            if(!(currentWeight >= maxWeight))
            {
                currentWeight += cookieCalories;
                gameObject.GetComponent<AudioSource>().clip = slurpSound;
                gameObject.GetComponent<AudioSource>().Play();
                Debug.Log("Ate cookie");
                Destroy(collision.gameObject);
            } else
            {
                gameObject.GetComponent<AudioSource>().clip = ewSound;
                gameObject.GetComponent<AudioSource>().Play();
            }

        }
    }

}
