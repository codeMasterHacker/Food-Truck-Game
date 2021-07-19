using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TruckSelect : MonoBehaviour
{
    public GameObject LeftTruck;
    public GameObject MidTruck;
    public GameObject RightTruck;
    public GameObject trucks;
    public GameObject TruckSelected;
    public char truckColor = '\0';

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void SceneSwitch()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void SetTruck()
    {
        if (trucks.transform.position == new Vector3(5.0f, 0.0f, 0.0f))
        {
            TruckSelected = LeftTruck;
            truckColor = 'b';
        }
        else if (trucks.transform.position == new Vector3(0.0f, 0.0f, 0.0f))
        {
            TruckSelected = MidTruck;
            truckColor = 'y';
        }
        else 
        {
            TruckSelected = RightTruck;
            truckColor = 'r';
        }
    }
}
