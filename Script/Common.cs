using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Revive : MonoBehaviour
{
    public float height, time, timeGiven, jumpForce;
    public Transform initStart;
    public Text timer;
    public float GoldPoint;
    public int charRotate = 90;  

    void Start()
    {
        time = timeGiven;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = time.ToString("f2");
        if (transform.position.y <= height) {
            transform.position = initStart.position;
            transform.eulerAngles = new Vector3(0, charRotate, 0);
        }
        if (time <= 0 ) {
            transform.position = initStart.position;
            time = timeGiven;
        }

        if (Input.GetKeyDown(KeyCode.Space)) { 
            GetComponent<Rigidbody>().AddForce(Vector3.up* jumpForce);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door") {
            Application.LoadLevel(1);
        }
    }
}
