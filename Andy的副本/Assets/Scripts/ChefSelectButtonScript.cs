using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ChefSelectButtonScript : MonoBehaviour
{
    public Text chefNameText, chefExpertiseText, chefStarsText, chefSalaryText, totalMoneyText;
    public Button selectChefButton, continueButton;
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        totalMoneyText.text = "Total Money $" + gameController.totalMoney.ToString("0,0.00", CultureInfo.InvariantCulture);
        continueButton.interactable = false;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void SelectChef()
    {
        continueButton.interactable = true;

        string expertise = chefExpertiseText.text;
        string[] foods = expertise.Split(',');

        string michelinStars = chefStarsText.text;
        string[] stars = michelinStars.Split();

        float salary = float.Parse(chefSalaryText.text, CultureInfo.CreateSpecificCulture("en-US"));
        Chef[] chefs = gameController.chefs;

        if (salary > gameController.totalMoney)
            return;

        bool flag = false;

        for (int i = 0; i < chefs.Length; i++)
        {
            if (chefs[i] == null)
            {
                chefs[i] = new Chef(chefNameText.text, foods, stars.Length, salary);
                gameController.totalMoney -= salary;
                totalMoneyText.text = "Total Money $" + gameController.totalMoney.ToString("0,0.00", CultureInfo.InvariantCulture);
                flag = true;
                break;
            }
        }

        if (flag)
            selectChefButton.interactable = false;

    }
}
