using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataReader : MonoBehaviour
{
    void Start()
    {
        readData("YearStateCSVs/1983Alabama.csv");
    }


    //List<string[]> readData(string fileAddress)
    void readData(string fileAddress)
    {
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader(fileAddress))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Debug.Log(line);
                }
            }
        }
        catch (System.Exception e)
        {
            // Let the user know what went wrong.
            Debug.Log(e.Message);
            Debug.Log("There is no such file.");
        }
    }
	
}
