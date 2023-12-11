using Godot;
using System;

public partial class Player : CharacterBody2D
{
	Vector2 playerPosition;
	Marker2D pivotPoint;
	CollisionShape2D collision;

	public override void _Ready()
	{	
		playerPosition = Position;

		pivotPoint = GetNode<Marker2D>("Pivot Point");

		collision = GetNode<CollisionShape2D>("CollisionShape2D");

		GD.Print($"Player position angle: { playerPosition.Angle() }"); 
		GD.Print($"collision position: {collision.Position}");
		GD.Print($"Pivot point position: {pivotPoint.Position}");
		GD.Print($"Player new position: {playerPosition + pivotPoint.Position}");

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
