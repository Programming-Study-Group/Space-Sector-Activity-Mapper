using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationMessage : MonoBehaviour
{
    public void closeInformationMessage()
    {
        gameObject.SetActive(false);
    }

    public void openInformationMessage()
    {
        gameObject.SetActive(true);
    }
}
