using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Transform bar;

    float size = 0.25f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            size += 0.25f;
            transform.localScale = new Vector3(size, 1f, 1f);
        }
    }
}
