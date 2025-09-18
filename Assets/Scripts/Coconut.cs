using UnityEngine;

public class Coconut : MonoBehaviour
{
    public CoconutFactory factory;
    public GameObject respawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Singleton.Instance.AddCoconut();
            Vector3 respawnPosition = respawn.transform.position;
            factory.SpawnCoconut(respawnPosition);
            Destroy(gameObject);
        }
    }
}