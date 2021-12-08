using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        for(int i = 0; i< 1; i++){
            Status();
        }
    }
    private void Status(){
        if(hero == null){
            Debug.Log("Ded");
        }
    }
}
