using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OrderingFood : MonoBehaviour
{
    public GameObject foodMenuPanelPanel;
    public GameObject[] customerLocations;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void OrderFood()
    {
        int size = foodMenuPanelPanel.transform.childCount;

        string[] foods = new string[size];
        for (int i = 0; i < size; i++)
            foods[i] = foodMenuPanelPanel.transform.GetChild(i).gameObject.GetComponent<FoodMenuScript>().foodMenuNameText.text;

        GameObject mapChoose = GameObject.Find("Canvas/MapChoose");
        int location = mapChoose.GetComponent<MapChoose>().intLocation;

        int numCustomers = customerLocations[location].transform.childCount;

        System.Random random = new System.Random();
        int index = random.Next(2, numCustomers);

        GameObject customer;
        List<GameObject> customers = new List<GameObject>();

        for (int i = 0; i < numCustomers; i++)
        {
            if (i % index == 0)
            {
                customer = customerLocations[location].transform.GetChild(i).gameObject;
                customer.SetActive(true);
                customers.Add(customer);
            }
        }

        StartCoroutine(DisplayOrders(customers, foods));
    }

    IEnumerator DisplayOrders(List<GameObject> customers, string[] foods)
    {
        System.Random random = new System.Random();
        int randFood, randQuantity;

        GameObject orderTextGameObject;
        TextMeshPro orderText;

        foreach (GameObject customer in customers)
        {
            orderTextGameObject = customer.transform.GetChild(customer.transform.childCount-1).gameObject;
            orderTextGameObject.SetActive(true);

            randQuantity = random.Next(1, 11);
            randFood = random.Next(foods.Length);

            orderText = orderTextGameObject.GetComponent<TextMeshPro>();
            orderText.text = randQuantity + " " + foods[randFood];

            yield return new WaitForSeconds(3);

            orderTextGameObject.SetActive(false);
        }

        //yield return new WaitForSeconds(3);

        char truckChosen = GameObject.Find("TruckChosen/Truck").GetComponent<TruckAcquire>().truckColor;

        switch (truckChosen)
        {
            case 'b': SceneManager.LoadScene("Blue Truck Inside"); break;
            case 'r': SceneManager.LoadScene("Red Truck Inside"); break;
            default: SceneManager.LoadScene("Yellow Truck Inside"); break;
        }

        // if statement checking for which truck we have
        //SceneManager.LoadScene("Food Making Scene");
    }
}
