using UnityEngine;

public class HW2PlayerRotation : MonoBehaviour
{
    private Camera _camera;

    private string Cameraname = "Game Camera";

    private void Start()
    {
        _camera = GameObject.Find(Cameraname).GetComponent<Camera>();
    }
}
