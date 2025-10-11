using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField] private GameObject NpcPrefab;

    private void ClientSpawn()
    {
        Instantiate(NpcPrefab);
    }
}
