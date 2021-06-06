public class Food
{
    private string name, description;
    private float price;

    public Food(string name, string description, float price)
    {
        this.name = name;
        this.description = description;
        this.price = price;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetPrice(float price)
    {
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public float GetPrice()
    {
        return price;
    }
}
