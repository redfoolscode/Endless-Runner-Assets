using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawnerScript : MonoBehaviour
{
    //Variables being used
    public float maxTime = 1;
    private float timer = 0;
    public GameObject[] ground;


    // Start is called before the first frame update
    void Start()
    {
        //Creating starting ground
        GameObject newground = Instantiate(ground[UnityEngine.Random.Range(0, ground.Length)]);
        newground.transform.position = transform.position + new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Creating ground over time
        if (timer > maxTime)
        {
            GameObject newground = Instantiate((ground[UnityEngine.Random.Range(0, ground.Length)]));
            newground.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(newground, 18);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
