using System.Linq;
using UnityEngine;

public class TestRayCast : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            RayCast();
    }


    private void RayCast()
    {
        var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition), 100.0f);
        Debug.Log("Raycast: " + AsStringNames(hits));
    }

    private string AsStringNames(RaycastHit[] hits)
    {
        return hits.ToList().Aggregate("", (t, h) => t += (" " + h.collider.gameObject.name));
    }
}