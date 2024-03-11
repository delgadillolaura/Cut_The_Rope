using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class MenuController : MonoBehaviour
{
    public void goToScene(int scene)
    {
        StarController.starCount = 0;
        SceneManager.LoadScene(scene);
    }
}
