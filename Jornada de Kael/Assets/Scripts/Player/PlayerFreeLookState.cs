using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState
{
    public PlayerFreeLookState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        // Implemente quaisquer a��es que voc� deseja realizar quando entrar neste estado
    }

    public override void Update(float deltaTime)
    {
        Vector3 movement = CalculateMovement();

        Move(deltaTime, movement);

        FaceMoveDirection(deltaTime, movement);
    }

    public override void Exit()
    {
        // Implemente quaisquer a��es que voc� deseja realizar quando sair deste estado
    }
}
