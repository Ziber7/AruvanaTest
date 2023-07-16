using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkButton : MonoBehaviour
{
    public GameObject Blinks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlinkFunction()
    {
        Blinks.SetActive(!Blinks.activeInHierarchy);
    }
}
