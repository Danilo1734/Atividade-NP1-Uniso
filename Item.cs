using UnityEditor.Build.Content;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int valor = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.Coletar(valor);
            Destroy(gameObject);
        }
    }
}
