using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [Header("KarakterYürüme")]
    public CharacterController movement;
    public GameObject tounchToScreen;
    public GameObject vibratePanelOff;
    public GameObject vibratePanelOn;
    [Header("KarakterLevel & Leveller")]
    public int characterLevel = 1;
    public int vibrateMilisc =100;
    
    [Header("LevelTextler")] 
    public TextMeshPro LevelText;
    

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        LevelText.text = "Lv." + characterLevel;
        
        if (characterLevel <= 0)
        {
            characterLevel = 0;
            
        }
        
    }
    public void StartGame()
    {
        movement.anim.SetBool("IsRun",true);
        movement.enabled = true;
        tounchToScreen.SetActive(false);
        
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    public void QuitGame()
    {
        Application.Quit();
        
    }
    public void VibrateOff()
    {
        vibrateMilisc = 0;
        vibratePanelOff.SetActive(false);
        vibratePanelOn.SetActive(true);
    }
    public void VibrateOn()
    {
        vibrateMilisc = 100;
        vibratePanelOn.SetActive(false);
        vibratePanelOff.SetActive(true);
    }
}

