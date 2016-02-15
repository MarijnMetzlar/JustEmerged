using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScene : MonoBehaviour {

    private GameObject startGame;
    private GameObject Story;
    private GameObject Exit;
    private GameObject backButton;
    private GameObject storyText;

    void Start()
    {
        startGame = GameObject.Find("Start");
        Story = GameObject.Find("Story");
        Exit = GameObject.Find("Exit");
        backButton = GameObject.Find("Button");
        storyText = GameObject.Find("Text");
        backButton.SetActive(false);
        storyText.SetActive(false);
    }

	public void StartGame()
    {
        Application.LoadLevel("Sandbox");
    }

    public void ShowStory()
    {
        startGame.SetActive(false);
        Story.SetActive(false);
        Exit.SetActive(false);
        backButton.SetActive(true);
        storyText.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void backMenu()
    {
        startGame.SetActive(true);
        Story.SetActive(true);
        Exit.SetActive(true);
        backButton.SetActive(false);
        storyText.SetActive(false);
    }
}
