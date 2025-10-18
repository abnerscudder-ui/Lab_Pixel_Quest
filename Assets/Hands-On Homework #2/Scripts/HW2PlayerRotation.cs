using UnityEngine;

public class HW2PlayerRotation : MonoBehaviour
{
    private Camera _camera;

    private string Cameraname = "Game Camera";

    private Vector3 _positionMouse;

    private void Start()
    {
        _camera = GameObject.Find(Cameraname).GetComponent<Camera>();
    }

    private void Update()
    {
       _positionMouse = _camera.ScreenToWorldPoint(Input.mousePosition);  

        Vector3 pos = _positionMouse - transform.position;
    }

}
