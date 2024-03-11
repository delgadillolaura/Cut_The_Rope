using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text starsText;

    private void Start()
    {
        starsText.text = "Stars: " + StarController.starCount.ToString();
    }

    public void goToScene(int scene)
    {
        StarController.starCount = 0;
        SceneManager.LoadScene(scene);
    }

    public void replayScene()
    {
        StarController.starCount = 0;
        SceneManager.LoadScene(CandyController.currentSceneIndex);
    }

    public void nextScene()
    {
        StarController.starCount = 0;
        SceneManager.LoadScene(CandyController.currentSceneIndex + 1);
    }
}
