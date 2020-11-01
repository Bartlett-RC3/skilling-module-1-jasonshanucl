using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Session1Homework : MonoBehaviour {


	//  1. declear variables..
	private int iNum1 = 3;			//iNum <-   variable name..    =  <- set variable    3 is the value.
	private int iNum2 = 2;
	private float iFloat = 1.5f;    // 1.5 float.   


	// Texts Initialize.
	private string mString = "Are you a tough guy?";


	//Logical variable initialize
	private bool mBool = false;   // logic value, only has 2 values. true and false.  boolean


	// Array initialize 
	private int[] mArray = {1,2,3};   //

	private float[] mFloat = new float[3];  // MALLOC 


	// List Initialize
	private List<float> mFloatList =  new List<float>();


	//Function define
	int mMultiple(int a, int b)
	{
		return a*b;
	}


	// Use this for initialization  : void means nothing return.
	void Start () 
	{
		Debug.Log("The result of "+ iNum1+ " multiply to "+iNum2+" is"+mMultiple(iNum1,iNum2));

		//Float array initialize
		mFloat[0] = 1.1f;  
		mFloat[1] = 1.2f;
		mFloat[2] = 1.3f;

		mArray[0] = iNum1;
        mArray[1] = iNum2;


        //Float List initialize
        mFloatList.Add(1.1f);
		mFloatList.Add(1.2f);
		mFloatList.Add(1.3f);
		mFloatList.Add(1.4f);

		float mFloatNum = mFloatList[0];

		
	}

	
	// Update is called once per frame
	void Update () {
        Debug.Log(mString);
        Debug.Log("do somethings..");

		bool ret = isSameNum(iNum1,iNum2);
	}


	//bool function.
	bool isNumEqualTo2(int a)
    {
		bool resault = false;

		if(a == 2)
        {
			resault = true;
        }

		return resault;
    }

    bool isSameNum(int a , int b)
    {
        bool resault = false;

        if (a == b)
        {
            resault = true;
        }

        return resault;
    }
}
