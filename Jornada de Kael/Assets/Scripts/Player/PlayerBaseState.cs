using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine sm;

    protected PlayerBaseState(PlayerStateMachine stateMachine)
    {
        sm = stateMachine;
    }

    protected void FaceMoveDirection(float deltaTime, Vector3 movement)
    {
        Quaternion rotation = sm.transform.rotation;
        Quaternion lookRotation = movement == Vector3.zero ? Quaternion.LookRotation(sm.transform.forward) :
            Quaternion.LookRotation(movement);

        sm.transform.rotation = Quaternion.Lerp(
            rotation, lookRotation,
            sm.RotationSpeed * deltaTime);
    }

    protected void Move(float deltaTime, Vector3 movement)
    {
        sm.Controller.Move(movement * (sm.FreeLookSpeed * deltaTime));
    }

    protected Vector3 CalculateMovement()
    {
        Vector2 InputMovement = sm.InputHandler.InputMovement;

        Vector3 movement = new Vector3(InputMovement.x, y: 0, z: InputMovement.y);
        return movement;
    }
}
