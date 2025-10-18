using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // syntax of functions:
    // public - access modifier, means this function can be accessed from other classes
    // ReturnType FunctionName(ParameterType parameterName, ...)  {... function body ... }
    // void means the function does not return any value
    // StartGame is the name of the function
    // () means the function does not take any parameters
    // {...} is the body of the function
    public void StartGame()
    {
        // SceneManager is an API from Unity that allows us to manage scenes
        // LoadScene is a function that loads a scene by its name or index
        // "Game" is the name of the scene we want to load
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        // SceneManager is an API from Unity that allows us to manage scenes
        // LoadScene is a function that loads a scene by its name or index
        // "Game" is the name of the scene we want to load
        Application.Quit();
    }
}