using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour {

	private Text txt;
	private bool showText;

	public AudioSource welcome;
	public AudioSource steering;
	public AudioSource gimble;
	public AudioSource shooting;
	public AudioSource jumping;
	public AudioSource strafing;
	public AudioSource nitro;
	public AudioSource flip;
	public AudioSource hull;
	
	// Use this for initialization
	void Start () 
	{
		txt = gameObject.GetComponent<Text> ();
		txt.text = "Welcome, this is your garage! Switch & upgrade your items here by clicking";
		welcome.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//sounds display!

		if (welcome.time > 24.1f) 
		{
			welcome.Stop ();
			txt.text = "You can drive your car by using: W,A,S,D";
			steering.Play ();
		}

		if (steering.time > 19.95f) 
		{
			steering.Stop ();
			txt.text = "Click your right mouse button to enter or exit gimbal mode";
			gimble.Play ();
		}

		if (gimble.time > 21.45f) 
		{
			gimble.Stop ();
			txt.text = "In gimbal mode you can shoot with your left mouse button";
			shooting.Play ();
		}

		if (shooting.time > 37.20f) 
		{
			shooting.Stop ();
			txt.text = "By pressing B you can do a short jump";
			jumping.Play ();
		}

		if (jumping.time > 17.80f) 
		{
			jumping.Stop ();
			txt.text = "You can make a strafe dash by pressing Q,E";
			strafing.Play ();
		}

		if (strafing.time > 16.70f) 
		{
			strafing.Stop ();
			txt.text = "Pressing shift will activate your nitro";
			nitro.Play ();
		}

		if (nitro.time > 20.40f) 
		{
			nitro.Stop ();
			txt.text = "If you are flipped, then you can turn around by pressing L";
			flip.Play ();
		}

		if (flip.time > 22.20f) 
		{
			flip.Stop ();
			txt.text = "JA OK";
			hull.Play ();
		}

		if (hull.time > 21.35f) 
		{
			hull.Stop ();
			txt.text = null;
			StopText ();
		}

		if(Input.GetKeyDown(KeyCode.Backspace))
		{
			StopText();
		}

		if(Input.GetKeyDown(KeyCode.RightShift))
		{
			txt.text = "You can drive your car by using: W,A,S,D";
			steering.Play ();
		}
	}

	void StopText()
	{
		welcome.Stop ();
		steering.Stop ();
		gimble.Stop ();
		shooting.Stop ();
		jumping.Stop ();
		strafing.Stop ();
		nitro.Stop ();
		flip.Stop ();
		hull.Stop ();
		txt.text = null;
	}
}