using UnityEngine;
using UnityEngine.SceneManagement; 

public class EnemyFollow : MonoBehaviour
{
    public Transform player; 
    public float speed = 3f; 
    public float distanceToFollow = 10f; 

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < distanceToFollow)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
            transform.LookAt(player);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Você perdeu!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}