using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSwitch : MonoBehaviour
{

    public GameObject trucks;
    public GameObject left;
    public GameObject right;

    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (trucks.transform.position == new Vector3(5.0f, 0.0f, 0.0f))
        {
            left.SetActive(false);
        }

        if (trucks.transform.position == new Vector3(-5.0f, 0.0f, 0.0f))
        {
            right.SetActive(false);
        }
    }

    public void Left()
    {
        if (trucks.transform.position != new Vector3(5.0f, 0.0f, 0.0f))
        {
            left.SetActive(true);
            right.SetActive(true);
            trucks.transform.position = trucks.transform.position + new Vector3(5.0f, 0.0f, 0.0f);
        }
    }

    public void Right() 
    {
        if (trucks.transform.position != new Vector3(-5.0f, 0.0f, 0.0f))
        {
            left.SetActive(true);
            right.SetActive(true);
            trucks.transform.position = trucks.transform.position + new Vector3(-5.0f, 0.0f, 0.0f);
        }
    }
}
