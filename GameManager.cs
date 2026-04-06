using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int pontos = 0;
    public int totalItens;

    public float tempoMaximo = 30f;
    private float tempoAtual;

    public UIManager ui;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        tempoAtual = tempoMaximo;
        ui.AtualizarTempo(tempoAtual);
    }

    void Update()
    {
        tempoAtual -= Time.deltaTime;

        ui.AtualizarTempo(tempoAtual);

        if (tempoAtual <= 0)
        {
            tempoAtual = 0;
            GameOver();
        }
    }

    public void Coletar(int valor)
    {
        pontos += valor;
        ui.AtualizarPontuacao(pontos);

        if (pontos >= totalItens)
        {
            ui.MostrarVitoria();
            Time.timeScale = 0f;
        }
    }

    public void GameOver()
    {
        ui.MostrarDerrota();
        Time.timeScale = 0f;
    }
}
