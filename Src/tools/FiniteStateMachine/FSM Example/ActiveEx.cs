using System;
using Godot;

public class ActiveEx : State {
  public override void ProcessState()
  {
    //GD.Print("Processing Active State");
  }

  public override void OnStateEnter()
  {
    GD.Print($"Entering {nameof(ActiveEx)}");
  }

  public override void OnStateExit()
  {
    GD.Print($"Exitting state {nameof(ActiveEx)}");
  }
}