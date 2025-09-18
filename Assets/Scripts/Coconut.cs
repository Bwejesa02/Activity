using UnityEngine;

public class Coconut : MonoBehaviour
{
    public CoconutFactory factory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Singleton.Instance.AddCoconut();
            Vector3 respawnPosition = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            factory.SpawnCoconut(respawnPosition);
            Destroy(gameObject);
        }
    }
}