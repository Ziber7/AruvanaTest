using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTouch : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private float rotationSpeedModifier = 0.5f;

    private bool isScaled;
    //private float scaleSpeed;
    public float ScaleSpeed = 0.5f;

    public Vector3 MinScale;
    public Vector3 MaxScale;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotationSpeedModifier, 0f);
                transform.rotation = rotationY * transform.rotation;
            }
        }

        if (Input.touchCount == 2)
        {
            // Menyimpan kedua touch
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Menginput kordinat dari kedua titik touch
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Menghitung nilai vector kedua titik touch
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Menghitung selisih dari kedua titik touch
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;    
        
            // Mengubah nilai Scale dari objek dengan mengalikan nilai selish
            // Nilai selisih diberi negatif karena selish berbanding terbalik dari scale 
            // Mengubah nilai scale dikarenakan AR Camera tidak dapat diubah fieldofview
            transform.localScale += Vector3.one * -deltaMagnitudeDiff * ScaleSpeed * Time.deltaTime;
        }
    }
    
}
