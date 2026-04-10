using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuc : MonoBehaviour
{
    [SerializeField] GameObject telaInicial;
    [SerializeField] GameObject telaMenu;
    [SerializeField] GameObject telaOpcoes;
    [SerializeField] GameObject telaCreditos;
    [SerializeField] GameObject telaLvl0;
    [SerializeField] GameObject telaLvl1;
    [SerializeField] GameObject telaLvl2;
    [SerializeField] GameObject telaLvl3;
    [SerializeField] GameObject telaLvl4;
    //[SerializeField] AudioClip somBotao;



    void Start()
    {
        HideUI();
        telaInicial.SetActive(true);
    }

    void HideUI()
    { 
        telaInicial.SetActive(false);
        telaMenu.SetActive(false);
        telaOpcoes.SetActive(false);
        telaCreditos.SetActive(false);
        telaLvl0.SetActive(false);
        telaLvl1.SetActive(false);
        telaLvl2.SetActive(false);
        telaLvl3.SetActive(false);
        telaLvl4.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Btn_Iniciar();
        }
    }
    public void Btn_Iniciar()
    {
        HideUI();
        telaMenu.SetActive(true);
    }

    public void Btn_Opcoes()
    {
        HideUI();
        telaOpcoes.SetActive(true);
        PlayButtonSound();
    }

    public void Btn_Creditos()
    {
        HideUI();
        telaCreditos.SetActive(true);
        PlayButtonSound();
    }

    public void Btn_Sair()
    {
        Application.Quit();
    }

    public void Btn_Voltar()
    {
        HideUI();
        telaMenu.SetActive(true);
        PlayButtonSound();
    }
    public void Btn_Lvl0()
    {
        HideUI();
        telaLvl0.SetActive(true);
        PlayButtonSound();
    }
    public void Btn_Lvl1()
    {
        HideUI();
        telaLvl1.SetActive(true);
        PlayButtonSound();
    }
    public void Btn_Lvl2()
    {
        HideUI();
        telaLvl2.SetActive(true);
        PlayButtonSound();
    }
    public void Btn_Lvl3()
    {
        HideUI();
        telaLvl3.SetActive(true);
        PlayButtonSound();
    }
    public void Btn_Lvl4()
    {
        HideUI();
        telaLvl4.SetActive(true);
        PlayButtonSound();
    }

    public void Btn_Jogar0()
    {
        SlidesManeger.instance.UpdateSlidesToShow(0);
        SceneManager.LoadScene("Story");
    }

    public void Btn_Jogar1()
    {
        
    }

    public void Btn_Jogar2()
    {
        
    }

    public void Btn_Jogar3()
    {
        
    }

    public void Btn_Jogar4()
    {
        
    }


    public void PlayButtonSound()
    {
        //AudioSource.PlayClipAtPoint(somBotao,this.transform.position);
        GetComponent<AudioSource>().Play();
    }
}