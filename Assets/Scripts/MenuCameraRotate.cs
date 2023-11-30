using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCameraRotate : MonoBehaviour
{

    float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0,1f * speed * Time.timeScale, 0);

    }
}
