using UnityEngine;
using System.Collections;

public class SpiritMovement : MonoBehaviour
{
    public static int barSectorNumber;
    private Vector3 spiritShift = new Vector3(0f, 0f, 1.5f);

    private void Awake()
    {
        barSectorNumber = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && barSectorNumber > 0)
        {
            StartCoroutine(ChangePositionLeft());
        }
        if (Input.GetKeyDown(KeyCode.D) && barSectorNumber < 2)
        {
            StartCoroutine(ChangePositionRight());
        }
    }

    private IEnumerator ChangePositionLeft()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Left");
        barSectorNumber--;
        transform.position -= spiritShift;
        Debug.Log(barSectorNumber);
    }
    private IEnumerator ChangePositionRight()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Right");
        barSectorNumber++;
        transform.position += spiritShift;
        Debug.Log(barSectorNumber);
    }
}
