using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Clicked on " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked on " + transform.position);
    }
}
