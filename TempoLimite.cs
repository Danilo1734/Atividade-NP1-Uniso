using UnityEngine;
using UnityEngine.SceneManagement;

public class TempoLimite : MonoBehaviour
{
    public float tempoMaximo = 30f;
    private float tempoAtual;

    void Start()
    {
        tempoAtual = tempoMaximo;
    }

    void Update()
    {
        tempoAtual -= Time.deltaTime;

        if (tempoAtual <= 0)
        {
            ReiniciarCena();
        }
    }

    void ReiniciarCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
