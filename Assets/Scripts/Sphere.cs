using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Material normalMaterial;
    public Material selectedMaterial;
    private static InfoManager infoManager;
    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        if (infoManager==null)
        {
            infoManager = GameObject.FindObjectOfType<InfoManager>();
        }
    }

    public void setColorToNormal()
    {
        renderer.material = normalMaterial;
    }

    public void setColorToSelected()
    {
        renderer.material = selectedMaterial;
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked on " + transform.position);
        infoManager.setSelectedSphere(this);
    }
}
