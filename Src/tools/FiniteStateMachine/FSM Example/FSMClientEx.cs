using System;
using Godot;

public class FSMClientEx : FiniteStateMachine { 
  public override void ProcessStates()
  {
    base.ProcessStates();
    switch (State.Name) {
      case nameof(IdleEx):
        if (Input.IsKeyPressed((int)KeyList.Space)) {
          ChangeState(nameof(ActiveEx));
        }
        break;
      case nameof(ActiveEx):
        if (!Input.IsKeyPressed((int)KeyList.Space)) {
          ChangeState(nameof(IdleEx));
        }
        break;
      default:
          break;
    }
  }
}