using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public float GoldPoint;
    public Text goldText;
    public int maxPoint = 9;
    void Start()
    {
        maxPoint = 9;
    }

   
    void Update()
    {
        goldText.text = GoldPoint.ToString("f2");
    }
    void OnCollisionEnter(Collision gold)
    {
        if (gold.gameObject.tag == "Gold")
        {
            GoldPoint += 5;
            maxPoint--;
            Destroy(gold.gameObject);
        }
        if (maxPoint <= 0) {
            Application.LoadLevel(0);
        }
        
    }
}
