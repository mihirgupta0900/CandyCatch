using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject candy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCandies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCandies()
    {
        while(true)
        {
            // Random x position
            float randomPosition = Random.Range(-10f, 10f);

            // Wait for 3 seconds
            yield return new WaitForSeconds(1);

            Instantiate(candy, new Vector2(randomPosition, 5), Quaternion.identity);
        }
    }
}
