using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    private Sphere selectedSphere;
    public Object prefab;
    
    
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            InitializeSphereWithLongtitudeLattitude("Istanbul", 28.98f, 41, 20);
        }        
    }
    void InitializeSphereWithXYZ(string code, float x, float y, float z)
    {
        GameObject go = Instantiate(prefab) as GameObject;
        Sphere newSphere = go.GetComponent<Sphere>();
        newSphere.setCode(code);
        //newSphere.setColorToNormal();   //TODO check to see whether this line is unnecessary
        go.transform.position = new Vector3(x, y, z);
    }

    void InitializeSphereWithLongtitudeLattitude(string code, float longtitude, float lattitude, float d)
    {
        float x = sin(longtitude) * cos(lattitude) * d;
        float y = sin(lattitude) * d;
        float z = -cos(longtitude) * cos(lattitude) * d;

        InitializeSphereWithXYZ(code, x, y, z);
    }

    private float sin(float x) //sin in degrees
    {
        return Mathf.Sin(x * Mathf.PI / 180);
    }
    private float cos(float x) //cos in degrees
    {
        return Mathf.Cos(x * Mathf.PI / 180);
    }

    public void setSelectedSphere(Sphere newSphere)
    {
        //change color of the previous sphere to normal
        if (selectedSphere!=null)
        {
            selectedSphere.setColorToNormal();
        }
        //set selectedSphere to new sphere
        selectedSphere = newSphere;
        //change color of the new sphere to "selection color"
        selectedSphere.setColorToSelected();
    }
}