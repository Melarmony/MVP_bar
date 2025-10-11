using UnityEngine;
using System.Collections;

public class NPCDestroy : MonoBehaviour
{
    private Vector3 NPCOutPoint = new Vector3(-6f, 1f, 4f);

    private float movementSpeed = 3f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(NPCAfterCoctail());
            Debug.Log(1);
        }
    }
    private IEnumerator NPCAfterCoctail()
    { 
        transform.position = Vector3.MoveTowards(transform.position, NPCOutPoint, movementSpeed * Time.deltaTime);
        yield return new WaitUntil(() => transform.position == NPCOutPoint);
    }
}
