using Godot;
using System;
using System.Linq;
using System.Collections.Generic;

public class FiniteStateMachine : Node {
  private Node parent;
  public Node Parent { get => Parent; }

  private State state;
  public State State { get => state; }

  private List<State> states = new();

  public override void _Ready() {
    parent = GetParentOrNull<Node>();
    foreach (State child in GetChildren()) {
      states.Add(child);
    }
    state = states[0];
  }

  public override void _Process(float delta) {
    ProcessStates();

    if (state != null) {
      state.ProcessState();
    }
  }
  
  public virtual void ProcessStates() {
  /*
  It is easy to make mistake in state names so you should always name state in editor and use nameof keyword.
  ex.
  Let's say that we have node of type State and we named it "Falling",
  so instead of using: case "Faling", you can type: case nameof(Falling).

  you probably didnt even noticed that i`ve made typo in bad use example.
  */
   switch (state.Name) {
    /*
    case "Idle":
      if (parent.velocity.y > 10) {
        changeState("Jumping");
      }
      break;
    */
    default:
        break;
    }
  }

  public void ChangeState(string newStateName) {
    State newState = null;
    foreach (var st in states) {
      if (st.Name == newStateName) {
        newState = st;
        break;
      }
    }
    ChangeState(newState: newState);
  }

  /// <summary>
  /// Changes state to given state reference.
  /// You should use ChangeState(string) for easier state managment as it searches for state with given name in state list
  /// </summary>
  /// <param name="newState">reference to state</param>
  public void ChangeState(State newState) {
    state.OnStateExit();
    newState.OnStateEnter();
    state = newState;
  }

  /// <summary>
  /// Returns parent property of given type <T> or <null> if no proprty is found
  /// </summary>
  /// <typeparam name="T">specify property type</typeparam>
  /// <param name="name">specify property name</param>
  /// <returns>property of given type or null</returns>
  public T GetProperty<T>(string name) {
    return (T)parent.Get(name);
  }
}
