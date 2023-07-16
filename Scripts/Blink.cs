using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public GameObject Logo;
    public bool blinkState;
    public float repeatTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeStateOfGameObject", 1f, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        //InvokeRepeating("ChangeStateOfGameObject", 1f, repeatTime);
    }

    void ChangeStateOfGameObject()
    {
        if(blinkState == true)
        {
            Logo.SetActive(!Logo.activeInHierarchy);
        }
    }

    public void ChangeState()
    {
        if(blinkState == true)
        {
            blinkState = false;
            Logo.SetActive(true);
        } else
        {
            blinkState = true;
            Logo.SetActive(true);
        }
    }
}
