using Godot;
using System;

public class State : Node {
  private FiniteStateMachine fsm;

  public override void _Process(float delta) {
    ProcessState();
  }

  public virtual void ProcessState() {
    //Put your state logic here
  }

  public virtual void OnStateEnter() {
    //What should happen while player is enterring state
  }

  public virtual void OnStateExit() {
    //What should happen while player is exittin state
  }
}
