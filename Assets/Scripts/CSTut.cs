using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSTut : MonoBehaviour
{
    double mana = 15.5;
    float speed = 5.0f;
    int health = 100;
    string playername = "warrior";
    bool isdead = false;

    // if u pass the code to Unity u can pull the unity components back like this

    private Rigidbody2D myBody;
    // then in the Start void...

    // ok this is like the constructor thing and you can pass params and use this.param
    // CSTut bigman
    // bigman = new CSTut(etc etc)
    // then u can use this thing called Info
    // bigman.Info(); to summon the params
    public CSTut() {
        Debug.Log("Health is: " + health);
        Debug.Log("Mana is: " + mana);
        Debug.Log("Movement is: " + speed);
        Debug.Log("Name is: " + playername);
        Debug.Log("Dead is: " + isdead);

    }
    private void Start()
    {
        // ... u can pull it down and manipulate values in the code instead of through Unity's Components UI
        myBody = GetComponent<Rigidbody2D>();
        //myBody.{Unity Thing}(what u change it to);

        float health = 100;

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("This is literally javascript, while loops are the same too");
        }
        switch (health)
        {

            case 100:
                Debug.Log("Health is 100");
                break;

            case 50:
                Debug.Log("Health is 50");
                break;

            case 0:
                Debug.Log("you dead");
                break;

            default:

                break;
        }
        StartCoroutine(ExecuteThing());
    }

    // some funky reusable trigger thing 
    // instead of void u do IEnumerator and now it's a coroutine
    // used for like time triggers and probably other triggers too 
    IEnumerator ExecuteThing()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("This is called a coroutine");
    }
        //    //CalcTwoNum(12, 12);

        //    Debug.Log("The sum is " + ReturnTwoNum());
        //}
        //void CalcTwoNum()
        //{
        //    float a = 10;
        //    float b = 12;
        //    float c = a + b;

        //    Debug.Log("Hello from the debug log (●'◡'●)");
        //    Debug.Log(a + " + " + b + " = " + c);

        //}

        //void CalcTwoNum(float a, float b) { 

        //    Debug.Log("The sum of a and b is: " + (a + b));
        //}

        //float ReturnTwoNum()
        //{
        //    return 20 + 30;
        //}
} // class