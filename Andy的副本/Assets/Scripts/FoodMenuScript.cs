using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodMenuScript : MonoBehaviour
{
    public Text foodMenuNameText, foodMenuDesText, foodMenuPriceText;
    public GameObject foodMenuItemPanel, chefsPanel, foodMenuPanel;

    private GameController gameController;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void PopulateFoodMenu()
    {
        chefsPanel.SetActive(false);
        foodMenuPanel.SetActive(true);

        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        Chef[] chefs = gameController.chefs;

        for (int i = 0; i < chefs.Length; i++)
        {
            if (chefs[i] == null)
                continue;

            string[] foods = chefs[i].GetFoods();

            for (int j = 0; j < foods.Length; j++)
            {
                GameObject clone = Instantiate(foodMenuItemPanel, GameObject.Find("Canvas/Food Menu Panel/Food Menu Items Panel/Scroll/Panel").transform);
                clone.SetActive(true);
                clone.GetComponent<FoodMenuScript>().foodMenuNameText.text = foods[j];

                //set description and price
            }
        }
    }
}
