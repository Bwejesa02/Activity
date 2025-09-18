using UnityEngine;

public class CoconutFactory : MonoBehaviour
{
    public GameObject coconutPrefab;

    public GameObject SpawnCoconut(Vector3 position)
    {
        return Instantiate(coconutPrefab, position, Quaternion.identity);
    }
}