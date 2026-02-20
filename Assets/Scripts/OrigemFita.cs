using UnityEngine;
using UnityEngine.SceneManagement;

public class OrigemFita : MonoBehaviour
{
    [SerializeField] RiboTubo prefabTuboC;
    [SerializeField] RiboTubo prefabTuboG;
    [SerializeField] RiboTubo prefabTuboT;
    [SerializeField] RiboTubo prefabTuboA;
    [SerializeField] float velocidadeDoMovimento = 5;
    [SerializeField] Transform trPontoDeSaida;
    RiboTubo tuboAtual;
    
    public void TeclaA ()
    {
        tuboAtual = Instantiate(
                 prefabTuboA,
                 trPontoDeSaida.position,
                 trPontoDeSaida.rotation);
        tuboAtual.Ritmo(velocidadeDoMovimento);        
    }

    public void RiboG ()
    {
        tuboAtual = Instantiate(
                 prefabTuboG,
                 trPontoDeSaida.position,
                 trPontoDeSaida.rotation);
        tuboAtual.Ritmo(velocidadeDoMovimento);
    }

    public void RiboC ()
    {
        tuboAtual = Instantiate(
                 prefabTuboC,
                 trPontoDeSaida.position,
                 trPontoDeSaida.rotation);
        tuboAtual.Ritmo(velocidadeDoMovimento);
    }

    public void RiboT()
    {
        tuboAtual = Instantiate(
                 prefabTuboT,
                 trPontoDeSaida.position,
                 trPontoDeSaida.rotation);
        tuboAtual.Ritmo(velocidadeDoMovimento);
    }

    public void Ganhou()
    {
        SceneManager.LoadScene("Story");
    }
}   
