using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YearScrollBar : MonoBehaviour
{
	Scrollbar bar;
	public Text text;

	private int yearMin = 1983, yearMax = 2016;

	void Start()
	{
		bar = this.GetComponent<Scrollbar>();
		text.text = getYear().ToString();
	}

	void Update()
	{
		text.text = getYear().ToString();
	}

	public float getYearValue()
	{
		return bar.value;
	}

	public int getYear()
	{
		return yearMin + (int) ((yearMax - yearMin) * getYearValue());
	}
}
