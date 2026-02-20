using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuc : MonoBehaviour
{
    [SerializeField] GameObject telaInicial;
    [SerializeField] GameObject telaMenu;
    [SerializeField] GameObject telaOpcoes;
    [SerializeField] GameObject telaCreditos;
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
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HideUI();
            telaMenu.SetActive(true);
        }
    }

    public void Btn_Comeco()
    {
        SlidesManeger.instance.UpdateSlidesToShow(0);
        SceneManager.LoadScene("Story");
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

    public void PlayButtonSound()
    {
        //AudioSource.PlayClipAtPoint(somBotao,this.transform.position);
        GetComponent<AudioSource>().Play();
    }
}
