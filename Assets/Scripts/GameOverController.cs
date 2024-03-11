using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text starsText;
    public Button nextButton;

    private void Start()
    {
        starsText.text = "Stars: " + StarController.starCount.ToString();
        if (CandyController.currentSceneIndex == 5)
        {
            nextButton.enabled = false;
            nextButton.gameObject.SetActive(false);
        }
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
        if (CandyController.currentSceneIndex < 5)
        {
            SceneManager.LoadScene(CandyController.currentSceneIndex + 1);
        }
    }
}
