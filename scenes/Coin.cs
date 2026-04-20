using Godot;
using System;

public partial class Coin : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.BodyEntered += OnBodyEntered;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void OnBodyEntered(Node2D body)
	{
		Godot.GD.Print("Coin collected by ", body.Name);

		const float ScaleFactor = 1.1f;
		body.Scale = new Vector2(body.Scale.X * ScaleFactor, body.Scale.Y * ScaleFactor);

		this.QueueFree(); //* Remove the coin from the scene
	}
}
