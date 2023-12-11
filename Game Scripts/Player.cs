using Godot;
using System;

public partial class Player : CharacterBody2D
{
	Marker2D pivotPoint;
	CollisionShape2D collision;

	Vector2 playerDirection;
	float angle = Mathf.Pi / 2;
	Vector2 ninetyDegree;
	public override void _Ready()
	{	
		pivotPoint = GetNode<Marker2D>("Pivot Point");
		collision = GetNode<CollisionShape2D>("CollisionShape2D");

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// playerDirection = (GetGlobalMousePosition() - this.Position ).Normalized();

		LookAt(GetGlobalMousePosition() ); //rotate player at mouse direction

	}
}
