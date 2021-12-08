using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 55;
    public Text clock;

    // Start is called before the first frame update
    void Start()
    {
        clock.text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        //clock.text = timer.ToString();
        clock.text = Mathf.Round(timer).ToString();
    }
}
