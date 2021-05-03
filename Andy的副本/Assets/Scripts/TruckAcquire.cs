using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckAcquire : MonoBehaviour
{
    public GameObject truckChosen;
    // Start is called before the first frame update
    void Start()
    {
        truckChosen = Instantiate(GameObject.Find("TruckSelect").GetComponent<TruckSelect>().TruckSelected);
        truckChosen.transform.position = new Vector3(0, 0, 0);
        Destroy(GameObject.Find("TruckSelect"), 1);
        truckChosen.GetComponent<TruckRotate>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
