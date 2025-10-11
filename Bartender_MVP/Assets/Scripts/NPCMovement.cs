using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    private Vector3 NPCStandPoint = new Vector3(-2f, 1f, 0f);

    private float movementSpeed = 2f;

    private void Update()
    {
        MoveToBar();
    }

    private void MoveToBar()
    {
        transform.position = Vector3.MoveTowards(transform.position, NPCStandPoint, movementSpeed * Time.deltaTime);
    }
}
