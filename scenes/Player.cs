//* Libraries imports
using Godot;

//* Local imports
using CoinCollector.Scripts;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	public override void _PhysicsProcess(double delta)
	{
		this.Velocity = new Vector2(0, 0);

		//* Left movement
		if (Godot.Input.IsActionPressed(Keys.Left))
		{
			Godot.GD.Print("Left");
			this.Velocity = new Vector2(-Speed, this.Velocity.Y);
		}

		//* Right movement
		if (Godot.Input.IsActionPressed(Keys.Right))
		{
			Godot.GD.Print("Right");
			this.Velocity = new Vector2(Speed, this.Velocity.Y);
		}

		//* Up movement
		if (Godot.Input.IsActionPressed(Keys.Up))
		{
			Godot.GD.Print("Up");
			this.Velocity = new Vector2(this.Velocity.X, -Speed);
		}

		//* Down movement
		if (Godot.Input.IsActionPressed(Keys.Down))
		{
			Godot.GD.Print("Down");
			this.Velocity = new Vector2(this.Velocity.X, Speed);
		}

		this.MoveAndSlide();
	}
}
