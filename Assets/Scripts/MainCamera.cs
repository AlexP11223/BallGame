using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;

    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
}