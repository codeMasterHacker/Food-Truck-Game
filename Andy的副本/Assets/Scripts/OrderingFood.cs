using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderingFood : MonoBehaviour
{
    public GameObject foodMenuPanelPanel, displayFoodOrdersPanel;
    public GameObject[] customerPrefabs;
    public int numCustomers = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (numCustomers < 1 || numCustomers > 6)
            numCustomers = 2;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    //access to the food menu panel and its children
    //create an array of food items/names
    //generate a random number between 1 and 10
    //create an array of the that size, representing the number of customers
    //randomly pick customer prefabs

    //for each customer, play their animation (walking up to food truck)
    //for each customer, display a text representing their order (food name + number of food items), pause for 2 seconds
    //after everyone orders, pause for 3 seconds
    //switch to food making scene

    public void OrderFood()
    {
        int size = foodMenuPanelPanel.transform.childCount;

        string[] foods = new string[size];
        for (int i = 0; i < size; i++)
            foods[i] = foodMenuPanelPanel.transform.GetChild(i).gameObject.GetComponent<FoodMenuScript>().foodMenuNameText.text;

        System.Random random = new System.Random();
        int index = random.Next(customerPrefabs.Length);

        for (int i = 0; i < numCustomers; i++)
        {
            GameObject customerGameObject = Instantiate(customerPrefabs[index], this.gameObject.transform);
            //play animation
        }
    }
}
