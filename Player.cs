using Godot;
using System;

public partial class Player : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	private float speed = 200.0f; // Define a speed variable

	public override void _Process(Double delta)
	{

	}
    public override void _Input(InputEvent @event) {
		if (@event is InputEventKey keyEvent && keyEvent.Pressed) {
			if (Input.IsKeyPressed(Key.A)) {
				LinearVelocity = new Vector2(-speed, 0);
			}
			else if (Input.IsKeyPressed(Key.D)) {
				LinearVelocity = new Vector2(-speed, 0);
			}
		}
	}
}
