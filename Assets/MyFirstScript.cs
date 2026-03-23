using UnityEngine;

public class MyfirstScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Hello!");

        // Variables class (Part 1)
        /*
        int health = 100;
        Debug.Log(health);
        health = 50;
        Debug.Log(health);
        */

        // Variables class (Part 2)
        /*
        int health = 100;
        Debug.Log(health);

        float moveSpeed = 5.25f;
        Debug.Log(moveSpeed);
        moveSpeed = 5.5024f;

        string playerName = "Bob";
        playerName = "Tim";

        bool gameOver = false;
        gameOver = true;
        */

        // Challenge variables
        /*
        string country = "Spain";
        int population = 30000;
        float highestAltitude = 4.32f;
        bool landlocked = false;
        */

        // Operators class
        /*
        int score = 0;
        score += 1;
        score += 5;
        Debug.Log(score);

        // Addition
        int a = 5;
        int b = 2;
        int c = a + b;
        Debug.Log(c);

        // Subtraction
        score -= 2;
        b = a - 3;

        // Multiplication
        score *= 5;
        b = 2 * c;

        // Division
        score /= 2;
        b = c / 4;


        float jumpHeight = 5.7f;
        jumpHeight *= 1.5f;

        string message = "Hello " + " world";

        // Money challenge
        int money = 10;

        money += 5;
        money *= 2;
        money -= 3;
        money /= 2;

        Debug.Log(money);
        */

        // Conditions class
        /*
        int score = 10;

        if (score == 10)
        {
            Debug.Log("Player has won!");
        }

        if (score != 10)
        {
            Debug.Log("Player does not have 10 score.");
        }

        int health = 50;

        if (health > 0)
        {
            Debug.Log("Player is still active.");
        }

        if (health <= 0)
        {
            Debug.Log("Player has been defeated!");
        }

        score = 75;
        if (score >= 90)
        {
            Debug.Log("A");
        }
        else if (score >= 70)
        {
            Debug.Log("B");
        }
        else if (score >= 50)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("D");
        }

        // Conditions challenge
        string country = "France";

        if (country == "France")
        {
            Debug.Log("It is France");
        }
        else
        {
            Debug.Log("It is NOT France");
        }
        */

        // Functions class
        /*
        LogToConsole();

        float number = Add(2.5f, 3.77f);
        Debug.Log(number);
        */

        // Vector class
        //Vector3 newPosition = new Vector3(3, -2, 4);
        //transform.position = newPosition;
    }

    void LogToConsole()
    {
        Debug.Log("This function has been called.");
    }

    float Add (float a, float b)
    {
        float sum = a + b;
        return sum;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 movement = new Vector3(1, 0, 0) * Time.deltaTime;
        // transform.position += movement;
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
    }
}
