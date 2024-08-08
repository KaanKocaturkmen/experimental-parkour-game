using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotSpeed = 0.5f;
    public float normalSpeed = 0.5f;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            this.transform.Translate(0, 0, normalSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            this.transform.Translate(0, 0, -normalSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            //this.transform.Translate(0, 0, 0.1)
            this.transform.Rotate(Vector3.up, -rotSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            //this.transform.Translate(0, 0, 0.1)
            this.transform.Rotate(Vector3.up, rotSpeed);
        }
    }
}
