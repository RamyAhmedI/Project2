using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Syringe;
    public GameObject life;
    public Transform character;
    public Vector3 syringe_position;
    int coolDown = 0;
    int shotsFired = 0;
    public float timer;
    public float timerLeft = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
      void shoot(){
             syringe_position = transform.position;
             GameObject syringe_shot = Instantiate(Syringe, syringe_position, Quaternion.identity);
             syringe_shot.transform.right = transform.right.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.UpArrow)) {
                     transform.eulerAngles = new Vector3(0,0,0);
                 }
                 else if (Input.GetKey (KeyCode.LeftArrow)) {
                     transform.eulerAngles = new Vector3(0,-90,0);
                 }
                 else if (Input.GetKey (KeyCode.DownArrow)) {
                     transform.eulerAngles = new Vector3(0,180,0);
                 }
                 else if (Input.GetKey (KeyCode.RightArrow)) {
                     transform.eulerAngles = new Vector3(0,90,0);
                 }
                 timer += Time.deltaTime;
                  if(Input.GetKeyDown(KeyCode.Space) && timer > timerLeft){
                    shoot();
                    timer = 0;
                 }
                  /*if(life == null){
                    Debug.Log("He ded");
                  }*/
         }
}
