using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;

    private CharacterController controller;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        inputActions = new InputSystem.actions("Move");
    }




}
