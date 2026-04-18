using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuUi;
    [SerializeField] GameObject LooseScreen;
    public static bool gameIsPaused = false;
    FMODUnity.StudioEventEmitter emitter;

    private void Start()
    {
        Btn_Resume();
        var target = GameObject.Find("Music starter");
        emitter = target.GetComponent<FMODUnity.StudioEventEmitter>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Btn_Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void Perdeu()
    {
        Time.timeScale = 0f;
        LooseScreen.SetActive(true);
    }
    public void Btn_Resume()
    {
        pauseMenuUi.SetActive(false);
        LooseScreen.SetActive(false);
        Time.timeScale = 1.0f;
        gameIsPaused = false;
    }
    public void Btn_menu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
    public void Btn_Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Btn_Acelerar()
    {
        Time.timeScale = 4.0f;
        emitter.SetParameter("Speed_Up", 4);
    }

    public void Btn_VelocidadeNormal()
    {
        Time.timeScale = 1.0f;
        emitter.SetParameter("Speed_Up", 1);
    }

    public void Btn_exit()
    {
        Application.Quit();
    }
}
