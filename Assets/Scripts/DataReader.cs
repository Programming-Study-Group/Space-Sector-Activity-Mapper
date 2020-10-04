using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataReader : MonoBehaviour
{
    private int year = 1983;    //TODO get year from the bar in unity
    /*
    void Start()
    {
        readData("YearStateCSVs/1983Alabama.csv");
    }
    */
    //void readData(string fileAddress)
    public List<string[]> readData(string sphereCode)
    {
        List<string[]> data = new List<string[]>();

        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            string fileAddress = "YearStateCSVs/" + year + sphereCode + ".csv";
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
            Debug.Log("There is no such file.");
        }
        return data;
    }
	
}
