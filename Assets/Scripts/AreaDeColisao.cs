using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class AreaDeColisao : MonoBehaviour
{
    [SerializeField] Transform tr;
    [SerializeField] Collider2D[] colisoresPorPerto;
    [SerializeField] float raioDeDeteccao = 2;
    [SerializeField] int vida = 3;
    [SerializeField] PauseMenu menu;
    [SerializeField] UiHpController UiHpController;
    [SerializeField] ScoreCounter score;
    [SerializeField] int amountToAddOnGreat = 3;
    [SerializeField] int amountToAddOnGood = 2;
    [SerializeField] int amountToAddOnBad = 1;
    [SerializeField] ParticleSystem particlePerfect;
    [SerializeField] ParticleSystem particleGood;
    [SerializeField] ParticleSystem particleBad;
    bool acertou;
    float distance;
    FMODUnity.StudioEventEmitter emitter;

    private void Start()
    {
        UiHpController.UpdateUI(vida);
        var target = GameObject.Find("Music starter");
        emitter = target.GetComponent<FMODUnity.StudioEventEmitter>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            VerificarArea(KeyCode.A);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            VerificarArea(KeyCode.S);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            VerificarArea(KeyCode.D);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            VerificarArea(KeyCode.F);
        }
        if(vida <= 0)
        {
            menu.Perdeu();
        }
    }

    public void BotaoA()
    {
        VerificarArea(KeyCode.A);
    }

    public void BotaoS()
    {
        VerificarArea(KeyCode.S);
    }

    public void BotaoD()
    {
        VerificarArea(KeyCode.D);
    }

    public void BotaoF()
    {
        VerificarArea(KeyCode.F);
    }
    void VerificarArea(KeyCode input)
    {       
        colisoresPorPerto = Physics2D.OverlapCircleAll(tr.position, raioDeDeteccao);

        if(colisoresPorPerto.Length == 0)
        {
            PerderVida();
        }

        foreach (Collider2D colisor in colisoresPorPerto)
        {

            if (colisor.gameObject.GetComponentInParent<RiboTubo>())
            {
                acertou = colisor.gameObject.GetComponentInParent<RiboTubo>().VerificarImput(input);
            }
            if (acertou)
            {
                distance = Vector3.Distance(this.gameObject.transform.position, colisor.gameObject.transform.position);
                if(distance < 0.25)
                {
                    score.AddScore(amountToAddOnGreat);
                    Instantiate(particlePerfect, colisor.gameObject.transform);
                }
                else if(distance < 0.5)
                {
                    score.AddScore(amountToAddOnGood);
                    Instantiate(particleGood, colisor.gameObject.transform);
                }
                else
                {
                    score.AddScore(amountToAddOnBad);
                    Instantiate(particleBad, colisor.gameObject.transform);
                }
                emitter.SetParameter("On_Off", 1);
            }
            else
            {
                PerderVida();
                score.MissedTheBonus();
                emitter.SetParameter("On_Off", 0);
            }
        }
    }

    public void PerderVida()
    {
        vida--;
        UiHpController.UpdateUI(vida);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, raioDeDeteccao);
    }
}
