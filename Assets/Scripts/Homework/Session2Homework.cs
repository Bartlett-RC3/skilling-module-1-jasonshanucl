using System.Collections.Generic;
using UnityEngine;
using AnimalWorld;


public class Session2Homework : MonoBehaviour
{
    private int mNum = 0;
    private bool mCondition = true;
    List<Dog> lGroup = new List<Dog>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)            // Here is a Loop
        {
            Debug.Log("Current Number is " + (++mNum));

            //Here is a condition
            if (mNum % 2 == 0)
            {
                Debug.Log("Current Number is a even number");

            }
            else
            {
                Debug.Log("Current Number is a odd number");
            }

        }

        // shorthand condition
        if(mCondition)
        {
            Debug.Log("do something..");
        }


        //class extension
        //Human Jason = new Human(18, 190, true, "Jason", "Shan");
        //Human Vinnie = new Human(18, 180, true, "Vinnie", "Chou");
        //lGroup.Add(Jason);
        //lGroup.Add(Vinnie);

        Dog Teddy = new Dog(50, 20, 2, "Teddy");
        Dog Bubby = new Dog(50, 20, 2, "Bubby");
        Dog Luffy = new Dog(50, 20, 2, "Luffy");

        for (int i=0;i<lGroup.Count;i++)
        {
            //Using class extension interface..
            Debug.Log("ID is " + i + "; First name is " + lGroup[i].GetName());
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}
