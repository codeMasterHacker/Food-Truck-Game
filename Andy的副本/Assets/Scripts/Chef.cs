public class Chef
{
    private string lastName;
    private string[] foods;
    private int michelinStars;
    private float monthlySalary;

    public Chef(string name, string[] expertise, int stars, float salary)
    {
        lastName = name;
        foods = expertise;
        michelinStars = stars;
        monthlySalary = salary;
    }

    public void SetLastName(string name)
    {
        lastName = name;
    }

    public void SetFoods(string[] expertise)
    {
        foods = expertise;
    }

    public void SetMichelinStars(int stars)
    {
        michelinStars = stars;
    }

    public void SetMonthlySalary(float salary)
    {
        monthlySalary = salary;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public string[] GetFoods()
    {
        return foods;
    }

    public int GetMichelinStars()
    {
        return michelinStars;
    }

    public float GetMonthlySalary()
    {
        return monthlySalary;
    }
}
