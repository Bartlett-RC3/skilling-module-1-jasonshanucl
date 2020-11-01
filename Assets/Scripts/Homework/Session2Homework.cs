using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OctaviansWorld;


public class Session2Homework : MonoBehaviour
{
    private int mNum = 0;
    List<Human> lGroup = new List<Human>();

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


        //class extension
        Human Jason = new Human(18, 190, true, "Jason", "Shan");
        Human Vinnie = new Human(18, 180, true, "Viinnie", "Chou");
        lGroup.Add(Jason);
        lGroup.Add(Vinnie);

        for(int i=0;i<lGroup.Count;i++)
        {
            //Using class extension api..
            Debug.Log("ID is " + i + "; First name is " + lGroup[i].GetFirstName());
        }



    }

    // Update is called once per frame
    void Update()
    {

    }
}
