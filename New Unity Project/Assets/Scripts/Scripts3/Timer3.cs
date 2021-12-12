using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer3 : MonoBehaviour
{
    public float timer = 46;
    public Text clock;

    // Start is called before the first frame update
    void Start()
    {
        clock.text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0){
        timer = timer - Time.deltaTime;
        //clock.text = timer.ToString();
        clock.text = Mathf.Round(timer).ToString();
        }
        else if(timer < 0 ){
            Application.LoadLevel("StoryLine4");
        }
    }
}