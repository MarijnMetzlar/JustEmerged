using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour {

	private Text txt;
	private float changeTextTimer = 5.0f;
	private int textOrder = 0;
	private bool showText;
	
	// Use this for initialization
	void Start () 
	{
		txt = gameObject.GetComponent<Text> ();
		txt.text = "Welcome, this is your garage! Switch & upgrade your items here by clicking";
	}
	
	// Update is called once per frame
	void Update () 
	{
		changeTextTimer -= Time.deltaTime;
		if (changeTextTimer < 0) 
		{
			if(textOrder == 0)
			{
				txt.text = "You can see your car details in the garage";
				textOrder += 1;
			}

			else if(textOrder == 1)
			{
				txt.text = "Press the leave garage button to start your adventure!";
				textOrder += 1;
			}

			else if(textOrder == 2)
			{
				txt.text = "You can drive your car by using: W,A,S,D";
				textOrder += 1;
			}

			else if(textOrder == 3)
			{
				txt.text = "Click your right mouse button to enter or exit gimbal mode";
				textOrder += 1;
			}

			else if(textOrder == 4)
			{
				txt.text = "In gimbal mode you can shoot with your left mouse button";
				textOrder += 1;
			}

			else if(textOrder == 5)
			{
				txt.text = "By pressing the spacebar you can do a short jump";
				textOrder += 1;
			}

			else if(textOrder == 6)
			{
				txt.text = "You can make a strafe dash by pressing Q,E";
				textOrder += 1;
			}

			else if(textOrder == 7)
			{
				txt.text = "Pressing shift will activate your nitro";
				textOrder += 1;
			}

			else if(textOrder == 8)
			{
				txt.text = "If you are flipped, then you can turn around by pressing L";
				textOrder += 1;
			}

			changeTextTimer = 5.0f;
		}
	}
}