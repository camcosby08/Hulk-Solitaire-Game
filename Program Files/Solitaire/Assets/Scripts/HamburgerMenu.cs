using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HamburgerMenu : MonoBehaviour
{
    public Button Hamburger;
    public Button Menu;
    public Button NewGame;
    public Button Quit;
    
    // public Button Resume;

    // Start is called before the first frame update
    void Awake()
    {
        Hamburger.gameObject.SetActive(true);
        Menu.gameObject.SetActive(false);
        NewGame.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenHamburgerMenu()
    {
        print("opening hamburger menu");
        Menu.gameObject.SetActive(true);
        NewGame.gameObject.SetActive(true);
        Quit.gameObject.SetActive(true);
        Hamburger.gameObject.SetActive(false);
        PauseGame.instance.Pause();
    }

    public void CloseHamburgerMenu()
    {
        print("closing hamburger menu");
        Hamburger.gameObject.SetActive(true);
        Menu.gameObject.SetActive(false);
        NewGame.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);
        PauseGame.instance.ResumeGame();
    }

    public void PressMainMenu()
    {
        print("Pressed Main Menu");
        //***Test code for Vegas 3 and vegas deal 1
        if ((MainMenu.GetOnVegas() && !MainMenu.GetDealThree()) || (MainMenu.GetOnVegas() && MainMenu.GetDealThree())) {
            Debug.Log("Main Menu: saving High Score for Vegas Deal");
            SaveHighScore.instance.CheckHighScore();
        }
        SceneManager.LoadScene("MainMenu");
    }

    public void PressNewGame()
    {
        print("Pressed New Game");
        //***Test code for Vegas 3 and vegas deal 1
        if ((MainMenu.GetOnVegas() && !MainMenu.GetDealThree()) || (MainMenu.GetOnVegas() && MainMenu.GetDealThree()))
        {
            Debug.Log("New Game: saving High Score for Vegas Deal");
            SaveHighScore.instance.CheckHighScore();
        }
        SceneManager.LoadScene("GameScene");
    }

    public void PressQuit()
    {
        print("Pressed Quit");
        Application.Quit();
    }

}