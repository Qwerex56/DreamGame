using System;
using Godot;

public class IdleEx : State {
  public override void ProcessState()
  {
    //GD.Print($"Processing {nameof(IdleEx)} State");
  }

  public override void OnStateEnter()
  {
    GD.Print($"Entering {nameof(IdleEx)}");
  }

  public override void OnStateExit()
  {
    GD.Print($"Exitting state {nameof(IdleEx)}");
  }
}