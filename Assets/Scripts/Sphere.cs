using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Material normalMaterial;
    public Material selectedMaterial;
    private static SphereManager sphereManager;
    private Renderer renderer;

    private string sphereCode;    //state name in the current application

    void Start()
    {
        renderer = GetComponent<Renderer>();
        if (sphereManager == null)
        {
            sphereManager = GameObject.FindObjectOfType<SphereManager>();
        }
    }

    public void setCode(string code)
    {
        sphereCode = code;
    }

    public void setColorToNormal()
    {
        if (renderer == null)
        {
            renderer = GetComponent<Renderer>();
        }
        renderer.material = normalMaterial;
    }

    public void setColorToSelected()
    {
        if (renderer == null)
        {
            renderer = GetComponent<Renderer>();
        }
        renderer.material = selectedMaterial;
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked on sphere with code:" + sphereCode + "  position:" + transform.position);
        sphereManager.setSelectedSphere(this);
    }
}
