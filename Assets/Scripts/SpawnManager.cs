using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame updateas
    public GameObject asteroidPrefab;
    public float time;
    public float asteroidSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 3.0f)
        {
            transform.position = new Vector3(8.5f, Random.Range(-4.5f, 4.5f), 0f);
            Instantiate(asteroidPrefab, transform.position, Quaternion.identity);

            time = 0;
        }

    }
}