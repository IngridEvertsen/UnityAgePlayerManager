using UnityEngine;


public class ageManager : MonoBehaviour
{
    public void IncreaseAge(int currentAge)
    {
        int newAge = currentAge + 1;

        Debug.Log("The players new age after 1 year is: " + newAge); 
    }
    
    public void IncreaseAge(int currentAge, int yearsToAdd)
    {
        int newAge = currentAge + yearsToAdd;

        Debug.Log("The player's new age after " + yearsToAdd + "year is: " +newAge);
    }

    void Start()
    {
        int initialAge = 22;
        int yearsToAdd1 = 5;
        int yearsToAdd2 = 10;

        IncreaseAge(initialAge);

        IncreaseAge(initialAge, yearsToAdd1);
        IncreaseAge(initialAge, yearsToAdd2);

    }
}

