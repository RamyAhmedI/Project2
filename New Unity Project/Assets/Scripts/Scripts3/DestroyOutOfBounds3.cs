using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds3: MonoBehaviour
{
    private float leftLimit = 158;
    private float rightLimit = 112;
    private float upLimit = 70;
    private float downLimit = -50;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > leftLimit){
            Destroy(gameObject);
        }
        else if (transform.position.x < rightLimit){
            Destroy(gameObject);
        }
        else if (transform.position.z < upLimit) {
            Destroy(gameObject);
        }
        else if (transform.position.z > downLimit) {
            Destroy(gameObject);
        }
    }
}
