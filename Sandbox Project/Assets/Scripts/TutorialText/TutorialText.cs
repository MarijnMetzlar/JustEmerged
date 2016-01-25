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

	public AudioSource gameMusic;
	
	// Use this for initialization
	void Start () 
	{
		txt = gameObject.GetComponent<Text> ();
		txt.text = "This is your Hangar, use the [+] and [-] to spend Upgrade points, press the buttons to change vehicle equipent and deploy.";
		welcome.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//sounds display!

		if (welcome.time > 24.1f) 
		{
			welcome.Stop ();
			txt.text = "Use [W,A,S,D] to Control your vehicle. Use [R] to Honk";
			steering.Play ();
		}

		if (steering.time > 19.95f) 
		{
			steering.Stop ();
			txt.text = "Use [Right Mouse Button] to enter and exit gimble mode";
			gimble.Play ();
		}

		if (gimble.time > 21.45f) 
		{
			gimble.Stop ();
			txt.text = "Use [Left Mouse Button] to Shoot while in gimble mode";
			shooting.Play ();
		}

		if (shooting.time > 37.20f) 
		{
			shooting.Stop ();
			txt.text = "Press [B] to jump";
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
			txt.text = "Use [Shift] to activate Ion Engines";
			nitro.Play ();
		}

		if (nitro.time > 20.40f) 
		{
			nitro.Stop ();
			txt.text = "Press [L]";
			flip.Play ();
		}

		if (flip.time > 22.20f) 
		{
			flip.Stop ();
			txt.text = "<< Damage Indicator <<";
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
			txt.text = "Use [W,A,S,D] to Control your vehicle.";
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