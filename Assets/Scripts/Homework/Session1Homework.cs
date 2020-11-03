using System.Collections.Generic;
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

	private Dictionary<string, int> mDic = new Dictionary<string, int>();

	//Function declear
	void mPrintVariables()
    {
		Debug.Log("My intege: " + iNum1 + " " + iNum2);
        Debug.Log("My float: " + iFloat);
        Debug.Log("My string: " + mString);
    }


	int mMultiple(int a, int b)
	{
		return a*b;
	}


	// Use this for initialization  : void means nothing return.
	void Start () 
	{
		Debug.Log("The result of "+ iNum1+ " multiply to "+iNum2+" is"+mMultiple(iNum1,iNum2));

		mPrintVariables();

        //Float List initialize
        mFloatList.Add(1.1f);
		mFloatList.Add(1.2f);
		mFloatList.Add(1.3f);
		mFloatList.Add(1.4f);

		//Dictionary Initialize;
		mDic.Add("Weight", 50);
        mDic.Add("Height", 180);
		
	}


    // Update is called once per frame
    void Update()
    {

	}

}
