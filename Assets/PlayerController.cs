using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Transform _camera;
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) _player.MoveLeft();
        if (Input.GetKey(KeyCode.W)) _player.MoveUp();
        if (Input.GetKey(KeyCode.D)) _player.MoveRight();
        if (Input.GetKey(KeyCode.S)) _player.MoveDown();
        if (Input.GetKey(KeyCode.Space)) _player.Movejump();
    }
    private void LateUpdate()
    {
        if (_camera.position.x != _player.transform.position.x
            || _camera.position.x != _player.transform.position.y)
        {
            _camera.position = new Vector3(_player.transform.position.x, _player.transform.position.y, -10f);
        }
    }
}