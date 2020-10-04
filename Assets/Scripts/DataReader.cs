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
            string fileAddress = "YearStateCSVs/" + year + sphereCode + ".csv";
            //Debug.Log("Looking for file: " + fileAddress);
            using (StreamReader sr = new StreamReader(fileAddress))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    data.Add(line.Split(','));
                }
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
        string fileAddress = "YearStateCSVs/" + year + sphereCode + ".csv";
        try
        {
            using (StreamReader sr = new StreamReader(fileAddress))
            {
                return true;
            }
        }
        catch
        {
            return false;
        }

    }

}
