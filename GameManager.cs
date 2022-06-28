using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;  //Change frame rate value

        Pause();
    }

    public void Play()  //Set value when start game
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

        FindObjectOfType<Item>().RandomizePosition();
        FindObjectOfType<BadItem>().RandomizePosition();
    }

    public void Pause()  //Freeze game in pause mode
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()  //Show game over message and pause game
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()  //Change score numbers in gameplay window
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void DecreaseScore() //Change score numbers in gameplay window
    {
        score--;
        scoreText.text = score.ToString();
    }
}
