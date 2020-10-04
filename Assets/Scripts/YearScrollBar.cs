using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YearScrollBar : MonoBehaviour
{
	Scrollbar bar;
	public Text text;
	public SphereManager sphereManager;

	private int yearMin = 1983, yearMax = 2016;


	//<code from https://stackoverflow.com/questions/44187844/how-to-detect-scrolling-up-or-down-in-panel-for-unity3d>
	float lastValue = 0;

	void OnEnable()
	{
		bar = this.GetComponent<Scrollbar>();
		text.text = getYear().ToString();
		//Subscribe to the Scrollbar event
		bar.onValueChanged.AddListener(scrollbarCallBack);
		lastValue = bar.value;
	}

	//Will be called when Scrollbar changes
	void scrollbarCallBack(float value)
	{
		if (lastValue != value)
		{
			text.text = getYear().ToString();
			sphereManager.checkSpheres();
		}
		lastValue = value;
	}

	//</>

	public float getYearValue()
	{
		return bar.value;
	}

	public int getYear()
	{
		return yearMin + (int) ((yearMax - yearMin) * getYearValue());
	}
}
