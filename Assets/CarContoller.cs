using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarContoller : MonoBehaviour
{   Transform tr;
    float speed = 1f;


    void Start()
    {
        Input.touchPressureSupported = false;
        tr = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        
    }
    public void GOgo(int a)
    {
     
      
    }

    


}

