using UnityEngine;

public class NpcController : MonoBehaviour
{
    public int npcID;
    public int npcSectorNumber;
    public Renderer npcAuraRender;


    private void Awake()
    {
        if (npcAuraRender == null)
        {
            npcAuraRender = GetComponentInChildren<Renderer>();
        }
    }
    public void SetAura(Color color, Material texture = null)
    {
        Material material = texture != null ? new Material(texture) : new Material(Shader.Find("Standard"));

        material.color = color;

        npcAuraRender.material = material;
    }
}
