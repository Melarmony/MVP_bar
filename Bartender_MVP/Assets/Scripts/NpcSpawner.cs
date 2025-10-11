using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField] private GameObject npcPrefab;
    [SerializeField] private Transform npcSpawnPosition;

    public static float clientCount = 0;

    private void Update()
    {
        ClientSpawn();
    }


    private void ClientSpawn()
    {
        if (clientCount == 0)
        {
            Instantiate(npcPrefab, npcSpawnPosition.position, npcSpawnPosition.rotation);
            clientCount++;
        }
    }
}
