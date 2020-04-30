using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    float dx=0, dy=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dx += Input.GetAxis("Mouse Y");
        dy += -Input.GetAxis("Mouse X");
        if (dx < -30) dx = -30;
        if (dx >  30) dx =  30;
        if (dy < -30) dy = -30;
        if (dy >  30) dy =  30;
        transform.eulerAngles = new Vector3(dx, 0, dy);
    }
}
