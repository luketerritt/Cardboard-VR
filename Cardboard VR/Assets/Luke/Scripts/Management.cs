using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Management : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Case()
    {
        SceneManager.LoadScene(2);
    }
    
    public void HomeScreen()
    {
        SceneManager.LoadScene(3);
    }
    public void MusicApp()
    {
        SceneManager.LoadScene(4);
    }
    public void VoiceMemoApp()
    {
        SceneManager.LoadScene(5);
    }
    public void MessagesApp()
    {
        SceneManager.LoadScene(6);
    }
    public void PhoneCallApp()
    {
        SceneManager.LoadScene(7);
    }
    public void PhotoApp()
    {
        SceneManager.LoadScene(8);
    }
    public void EndGame()
    {
        SceneManager.LoadScene(9);
    }
    public void NotesApp()
    {
        SceneManager.LoadScene(10);
    }
    public void WeatherApp()
    {
        SceneManager.LoadScene(11);
    }
    public void ExitGame()
    {
        Application.Quit(0);
    }
}

