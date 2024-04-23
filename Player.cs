using Godot;
using System;

public partial class Player : MeshInstance2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	private float speed = 200.0f; // Define a speed variable

	public override void _Process(Double delta)
	{
		Vector2 velocity = new Vector2(); // Start with a vector that is not moving

		// Check for input and adjust the velocity vector accordingly
		if (Input.IsActionPressed("ui_right"))
		{
			velocity.X += 1;
		}

		if (Input.IsActionPressed("ui_left"))
		{
			velocity.X -= 1;
		}

		if (Input.IsActionPressed("ui_down"))
		{
			velocity.Y += 1;
		}

		if (Input.IsActionPressed("ui_up"))
		{
			velocity.Y -= 1;
		}

		// If the velocity vector is not zero, normalize it and multiply by the speed to get the final velocity
		if (velocity.Length() > 0)
		{
			velocity = velocity.Normalized() * speed;
		}

	}
	
}
