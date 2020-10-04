using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DataReader : MonoBehaviour
{
    public YearScrollBar yearScrollBar;

    public List<string[]> readData(string sphereCode)
    {
        int year = yearScrollBar.getYear();

        List<string[]> data = new List<string[]>();
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            string fileAddress = "Data/" + year + sphereCode;
            TextAsset textAsset = (TextAsset)Resources.Load<TextAsset>(fileAddress);
            string[] lines = textAsset.text.Split('\n');
            foreach (string line in lines)
            {
                data.Add(line.Split(','));
            }
        }
        catch (System.Exception e)
        {
            // Let the user know what went wrong.
            Debug.Log(e.Message);
        }
        return data;
    }

    public bool fileExists(string sphereCode)   //TODO find a better way to check if file exists
    {
        int year = yearScrollBar.getYear();
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            string fileAddress = "Data/" + year + sphereCode;
            TextAsset textAsset = (TextAsset)Resources.Load<TextAsset>(fileAddress);
            return (textAsset!=null);
        }
        catch (System.Exception e)
        {
            // Let the user know what went wrong.
            return false;
        }
    }

}
