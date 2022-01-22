using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerScript : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _playerVelocity;

    private PlayerControlls _input;

    private bool _groundedPlayer;
    private const float PlayerSpeed = 2.0f;
    private const float JumpHeight = 1.0f;
    private const float GravityValue = -9.81f;

    // Start is called before the first frame update
    private void Start()
    {
        _controller = gameObject.AddComponent<CharacterController>();
        _input = new PlayerControlls();
        _input.Enable();
        _input.KeyboardMouse.Jump.performed += Jump;
    }

    // Update is called once per frame
    private void Update()
    {
        var wasdInput = _input.KeyboardMouse.WASD.ReadValue<Vector2>();


        _groundedPlayer = _controller.isGrounded;
        if (_groundedPlayer && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0f;
        }

        var move = new Vector3(wasdInput.x, 0, wasdInput.y);
        _controller.Move(move * Time.deltaTime * PlayerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        _playerVelocity.y += GravityValue * Time.deltaTime;
        _controller.Move(_playerVelocity * Time.deltaTime);
    }

    private void Jump(InputAction.CallbackContext space)
    {
        if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),  1.5f))
        {
            return;
        }

        _playerVelocity.y += Mathf.Sqrt(JumpHeight * -3.0f * GravityValue);
    }
}