using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField] private GameObject npcPrefab;
    [SerializeField] private Transform npcSpawnPosition;

    [SerializeField] private Material[] auraTextures;
    [SerializeField] private Color[] auraColors = new Color[6] 
    {
        Color.red, Color.blue, Color.green, Color.yellow, Color.magenta, Color.cyan
    };

    public static int nextNpcID = 0;
    public static int clientCount = 0;

    private void Update()
    {
        ClientSpawn();
    }


    private void ClientSpawn()
    {
        if (clientCount == 0)
        {
            GameObject npcObject = Instantiate(npcPrefab, npcSpawnPosition.position, npcSpawnPosition.rotation);
            var npc = npcObject.GetComponent<NpcController>();

            npc.npcID = nextNpcID;
            nextNpcID++;

            Color auraColor = auraColors[Random.Range(0, auraColors.Length)];
            Material auraTexture = auraTextures.Length > 0 ? auraTextures[Random.Range(0, auraTextures.Length)] : null;

            npc.SetAura(auraColor, auraTexture);

            clientCount++;
        }
    }
}
