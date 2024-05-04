using Godot;
using System;

public partial class Player : RigidBody2D
{
	private bool Floor = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	private float speed = 200.0f; // Define a speed variable

	public override void _Process(Double delta)
	{
		if(LinearVelocity.Y == 0){
			Floor = true;
		}
		else{
			Floor = false;
		}
	}
    public override void _Input(InputEvent @event) {
		if (@event is InputEventKey keyEvent && keyEvent.Pressed) {
			 
			if (Input.IsKeyPressed(Key.A)) {
				if (LinearVelocity.X <=  -200) {
					LinearVelocity = new Vector2(-200, 0);
				}
				else {
					LinearVelocity += new Vector2(-speed, 0);
				}
			}
			else if (Input.IsKeyPressed(Key.D)) {
				if (LinearVelocity.X >=  200) {
					LinearVelocity = new Vector2(200, 0);
				}
				else {
					LinearVelocity -= new Vector2(-speed, 0);
				}
			}
			if(Input.IsKeyPressed(Key.Space) && Floor){
				LinearVelocity += new Vector2(0, -500);
			}
		}
	}
}
