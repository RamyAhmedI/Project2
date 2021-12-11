using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds2: MonoBehaviour
{
    private float leftLimit = 35;
    private float rightLimit = 15;
    private float upLimit = 60;
    private float downLimit = 120;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit){
            Destroy(gameObject);
        }
        else if (transform.position.x > rightLimit){
            Destroy(gameObject);
        }
        else if (transform.position.z > upLimit) {
            Destroy(gameObject);
        }
        else if (transform.position.z < downLimit) {
            Destroy(gameObject);
        }
    }
}
