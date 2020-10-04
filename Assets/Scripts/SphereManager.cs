using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    private Sphere selectedSphere;
    public Object prefab;

    private bool istanbulInitialized = false, statesInitialized = false;
    void Update()
    {
        if (!istanbulInitialized && Input.GetKeyDown("i"))
        {
            InitializeSphereWithLongtitudeLattitude("Istanbul", 28.98f, 41, 20);
            istanbulInitialized = true;
        }
        //data from https://developers.google.com/public-data/docs/canonical/states_csv
        if (!statesInitialized && Input.GetKeyDown("s"))
        {
            //written with Python
            InitializeSphereWithLongtitudeLattitude("Alaska", -154.493062f, 63.588753f, 20);
            InitializeSphereWithLongtitudeLattitude("Alabama", -86.902298f, 32.318231f, 20);
            InitializeSphereWithLongtitudeLattitude("Arkansas", -91.831833f, 35.20105f, 20);
            InitializeSphereWithLongtitudeLattitude("Arizona", -111.093731f, 34.048928f, 20);
            InitializeSphereWithLongtitudeLattitude("California", -119.417932f, 36.778261f, 20);
            InitializeSphereWithLongtitudeLattitude("Colorado", -105.782067f, 39.550051f, 20);
            InitializeSphereWithLongtitudeLattitude("Connecticut", -73.087749f, 41.603221f, 20);
            InitializeSphereWithLongtitudeLattitude("District of Columbia", -77.033418f, 38.905985f, 20);
            InitializeSphereWithLongtitudeLattitude("Delaware", -75.52767f, 38.910832f, 20);
            InitializeSphereWithLongtitudeLattitude("Florida", -81.515754f, 27.664827f, 20);
            InitializeSphereWithLongtitudeLattitude("Georgia", -82.907123f, 32.157435f, 20);
            InitializeSphereWithLongtitudeLattitude("Hawaii", -155.665857f, 19.898682f, 20);
            InitializeSphereWithLongtitudeLattitude("Iowa", -93.097702f, 41.878003f, 20);
            InitializeSphereWithLongtitudeLattitude("Idaho", -114.742041f, 44.068202f, 20);
            InitializeSphereWithLongtitudeLattitude("Illinois", -89.398528f, 40.633125f, 20);
            InitializeSphereWithLongtitudeLattitude("Indiana", -85.602364f, 40.551217f, 20);
            InitializeSphereWithLongtitudeLattitude("Kansas", -98.484246f, 39.011902f, 20);
            InitializeSphereWithLongtitudeLattitude("Kentucky", -84.270018f, 37.839333f, 20);
            InitializeSphereWithLongtitudeLattitude("Louisiana", -92.145024f, 31.244823f, 20);
            InitializeSphereWithLongtitudeLattitude("Massachusetts", -71.382437f, 42.407211f, 20);
            InitializeSphereWithLongtitudeLattitude("Maryland", -76.641271f, 39.045755f, 20);
            InitializeSphereWithLongtitudeLattitude("Maine", -69.445469f, 45.253783f, 20);
            InitializeSphereWithLongtitudeLattitude("Michigan", -85.602364f, 44.314844f, 20);
            InitializeSphereWithLongtitudeLattitude("Minnesota", -94.6859f, 46.729553f, 20);
            InitializeSphereWithLongtitudeLattitude("Missouri", -91.831833f, 37.964253f, 20);
            InitializeSphereWithLongtitudeLattitude("Mississippi", -89.398528f, 32.354668f, 20);
            InitializeSphereWithLongtitudeLattitude("Montana", -110.362566f, 46.879682f, 20);
            InitializeSphereWithLongtitudeLattitude("North Carolina", -79.0193f, 35.759573f, 20);
            InitializeSphereWithLongtitudeLattitude("North Dakota", -101.002012f, 47.551493f, 20);
            InitializeSphereWithLongtitudeLattitude("Nebraska", -99.901813f, 41.492537f, 20);
            InitializeSphereWithLongtitudeLattitude("New Hampshire", -71.572395f, 43.193852f, 20);
            InitializeSphereWithLongtitudeLattitude("New Jersey", -74.405661f, 40.058324f, 20);
            InitializeSphereWithLongtitudeLattitude("New Mexico", -105.032363f, 34.97273f, 20);
            InitializeSphereWithLongtitudeLattitude("Nevada", -116.419389f, 38.80261f, 20);
            InitializeSphereWithLongtitudeLattitude("New York", -74.217933f, 43.299428f, 20);
            InitializeSphereWithLongtitudeLattitude("Ohio", -82.907123f, 40.417287f, 20);
            InitializeSphereWithLongtitudeLattitude("Oklahoma", -97.092877f, 35.007752f, 20);
            InitializeSphereWithLongtitudeLattitude("Oregon", -120.554201f, 43.804133f, 20);
            InitializeSphereWithLongtitudeLattitude("Pennsylvania", -77.194525f, 41.203322f, 20);
            InitializeSphereWithLongtitudeLattitude("Puerto Rico", -66.590149f, 18.220833f, 20);
            InitializeSphereWithLongtitudeLattitude("Rhode Island", -71.477429f, 41.580095f, 20);
            InitializeSphereWithLongtitudeLattitude("South Carolina", -81.163725f, 33.836081f, 20);
            InitializeSphereWithLongtitudeLattitude("South Dakota", -99.901813f, 43.969515f, 20);
            InitializeSphereWithLongtitudeLattitude("Tennessee", -86.580447f, 35.517491f, 20);
            InitializeSphereWithLongtitudeLattitude("Texas", -99.901813f, 31.968599f, 20);
            InitializeSphereWithLongtitudeLattitude("Utah", -111.093731f, 39.32098f, 20);
            InitializeSphereWithLongtitudeLattitude("Virginia", -78.656894f, 37.431573f, 20);
            InitializeSphereWithLongtitudeLattitude("Vermont", -72.577841f, 44.558803f, 20);
            InitializeSphereWithLongtitudeLattitude("Washington", -120.740139f, 47.751074f, 20);
            InitializeSphereWithLongtitudeLattitude("Wisconsin", -88.787868f, 43.78444f, 20);
            InitializeSphereWithLongtitudeLattitude("West Virginia", -80.454903f, 38.597626f, 20);
            InitializeSphereWithLongtitudeLattitude("Wyoming", -107.290284f, 43.075968f, 20);
            statesInitialized = true;
        }
    }
    void InitializeSphereWithXYZ(string code, float x, float y, float z)
    {
        GameObject go = Instantiate(prefab) as GameObject;
        Sphere newSphere = go.GetComponent<Sphere>();
        newSphere.setCode(code);
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