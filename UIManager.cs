using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPontuacao;
    public GameObject telaVitoria;
    public GameObject telaDerrota;
    public TextMeshProUGUI textoTempo;

    public void AtualizarPontuacao(int pontos)
    {
        textoPontuacao.text = "Itens: " + pontos;
    }

    public void MostrarVitoria()
    {
        telaVitoria.SetActive(true);
        Debug.Log("Vitoria!");
    }

    public void MostrarDerrota()
    {
        telaDerrota.SetActive(true);
        Debug.Log("Derrota!");
    }

    public void AtualizarTempo(float tempo)
    {
        int tempoInteiro = Mathf.CeilToInt(tempo);
        textoTempo.text = "Tempo: " + tempoInteiro.ToString();
    }
}
