﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationMessage : MonoBehaviour
{
    public void closeInformationMessage()
    {
        gameObject.active = false;
    }

    public void openInformationMessage()
    {
        gameObject.active = true;
    }
}
