using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    private Sphere selectedSphere;

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