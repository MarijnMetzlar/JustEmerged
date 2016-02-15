using UnityEngine;
using System.Collections;

public class FadeInScreen : MonoBehaviour {
		
	public Texture2D fadeInTexture;
	public float fadeInSpeed = 0.8f;
		
	private float alpha = 1.0f;
	private int fadeDir = -1;

	private float fadeTimer = 2.5f;
		
	//this class creates a fading-in effect when a level started
	//the black texture (that is attached) his alpha value will become lower.
	//so the black image will fade away when the code starts
	//it will be covered on the whole screen.

	void Update()
	{
		fadeTimer -= Time.deltaTime;
		if (fadeTimer < 0) 
		{
			Destroy(gameObject);
		}
	}

	void OnGUI()
	{
		alpha += fadeDir * fadeInSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);
			
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeInTexture);
	}
}
