using UnityEngine;
using System.Collections;

public class coinScript : MonoBehaviour 
{
	int frameNum;
	bool flipLeft = false;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(frameNum % 100 == 0)
		{
			flipLeft = !flipLeft;

			if (flipLeft)
			{
				//change the coin's picture to left oriented
			}
			else
			{
				//change the coin's picture to right oriented
			}
		}

		frameNum++;
	}
}
