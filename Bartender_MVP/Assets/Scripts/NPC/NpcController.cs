using UnityEngine;

public class NpcController : MonoBehaviour
{
    public int npcID;
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
        var material = texture != null ? new Material(texture) : new Material(Shader.Find("Standard"));

        material.color = color;

        npcAuraRender.material = material;
    }
}
