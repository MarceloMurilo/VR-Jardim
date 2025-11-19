using UnityEngine;

public class HoleDetector : MonoBehaviour
{
    public GameObject seedlingPrefab;   // A ARVORE!
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrou no buraco: " + other.name);

        if (other.CompareTag("Semente"))
        {
            Debug.Log("A semente foi detectada!");

            // Destroi a semente
            Destroy(other.gameObject);

            // Instancia a árvore
            Instantiate(seedlingPrefab, spawnPoint.position, Quaternion.identity);

            Debug.Log("Árvore spawnada!");
        }
    }
}
