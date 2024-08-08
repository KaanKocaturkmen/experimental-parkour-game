using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool stop;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            stop = !stop;
        }
        if (stop)
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
