using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private static SphereManager sphereManager;
    private Renderer sphereRenderer;

    private string sphereCode;    //state name in the current application

    void Awake()
    {
        sphereRenderer = GetComponent<Renderer>();
        if (sphereManager == null)
        {
            sphereManager = GameObject.FindObjectOfType<SphereManager>();
        }
    }

    public void setCode(string code)
    {
        sphereCode = code;
    }

    public string getCode()
    {
        return sphereCode;
    }

    public void setColorToNormal()
    {
        if (sphereRenderer == null)
        {
            sphereRenderer = GetComponent<Renderer>();
        }
        sphereRenderer.material = sphereManager.normal;
    }

    public void setColorToSelected()
    {
        if (sphereRenderer == null)
        {
            sphereRenderer = GetComponent<Renderer>();
        }
        sphereRenderer.material = sphereManager.selected;
    }

    void OnMouseDown()
    {
        sphereManager.setSelectedSphere(this);
    }
}
