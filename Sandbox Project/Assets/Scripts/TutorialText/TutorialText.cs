using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour {

	private Text txt;
	private float changeTextTimer = 5.0f;
	private int textOrder = 0;
	
	// Use this for initialization
	void Start () 
	{
		txt = gameObject.GetComponent<Text> ();
		txt.text = "Press the spacebar!";
	}
	
	// Update is called once per frame
	void Update () 
	{
		changeTextTimer -= Time.deltaTime;
		if (changeTextTimer < 0) 
		{
			if(textOrder == 0)
			{
				txt.text = "You can drive by using ASDW";
				textOrder += 1;
			}

			else if(textOrder == 1)
			{
				txt.text = "Fill in the rest tagor";
				textOrder += 1;
			}

			else if(textOrder == 2)
			{
				txt.text = "Fill in the rest tagor2";
				textOrder += 1;
			}

			else if(textOrder == 3)
			{
				txt.text = "Fill in the rest tagor3";
				textOrder += 1;
			}

			else if(textOrder == 4)
			{
				txt.text = "Fill in the rest tagor4";
				textOrder += 1;
			}

			else if(textOrder == 5)
			{
				txt.text = "Fill in the rest tagor5";
				textOrder += 1;
			}

			changeTextTimer = 5.0f;
		}
	}
}