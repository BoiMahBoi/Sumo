using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSpawner : MonoBehaviour
{
    public GameObject cookiePrefab;
    private Vector3 spawnLocation;
    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCookie());
    }

    public IEnumerator SpawnCookie()
    {
        yield return new WaitForSeconds(Random.Range(2, 4));
        spawnLocation = new Vector3(Random.Range(-x, x), Random.Range(-y, y), 1);
        Instantiate(cookiePrefab, spawnLocation, Quaternion.identity);
        StartCoroutine(SpawnCookie());
    }
}
