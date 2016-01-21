using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour {

	private Text txt;
	public float changeTextTimer = 4.0f;
	public int textOrder = 0;
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
				changeTextTimer = 4.0f;
			}

			else if(textOrder == 1)
			{
				txt.text = "Press the leave garage button to start your adventure!";
				textOrder += 1;
				changeTextTimer = 4.0f;
			}

			else if(textOrder == 2)
			{
				txt.text = "You can drive your car by using: W,A,S,D";
				textOrder += 1;
				changeTextTimer = 0.0f;
			}

			else if(textOrder == 3)
			{
				if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W))
				{
					txt.text = "Click your right mouse button to enter or exit gimbal mode";
					textOrder += 1;
				}
				changeTextTimer = 0.0f;
			}

			else if(textOrder == 4)
			{
				if(Input.GetMouseButtonDown(1))
				{
					txt.text = "In gimbal mode you can shoot with your left mouse button";
					textOrder += 1;
				}
				changeTextTimer = 0.0f;
			}

			else if(textOrder == 5)
			{
				if(Input.GetMouseButtonDown(0))
				{
					txt.text = "By pressing the spacebar you can do a short jump";
					textOrder += 1;
				}
				changeTextTimer = 0.0f;
			}

			else if(textOrder == 6)
			{
				if(Input.GetKeyDown(KeyCode.Space))
				{
					txt.text = "You can make a strafe dash by pressing Q,E";
					textOrder += 1;
				}
				changeTextTimer = 0.0f;
			}

			else if(textOrder == 7)
			{
				if(Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
				{
					txt.text = "Pressing shift will activate your nitro";
					textOrder += 1;
				}
				changeTextTimer = 0.0f;
			}

			else if(textOrder == 8)
			{
				if(Input.GetKeyDown(KeyCode.LeftShift))
				{
					txt.text = "If you are flipped, then you can turn around by pressing L";
					textOrder += 1;
					changeTextTimer = 4.0f;
				}
			}
			
			else if(textOrder == 9)
			{
				txt.text = null;
				changeTextTimer = 0.0f;
			}
		}
	}
}