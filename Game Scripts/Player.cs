using Godot;
using System;

public partial class Player : CharacterBody2D
{
	Marker2D pivotPoint;

	CollisionShape2D collision;

	Vector2 playerDirection; //walking direction

	float angle = Mathf.Pi / 2;

	float speed = 400;

	public override void _Ready()
	{	
		pivotPoint = GetNode<Marker2D>("Pivot Point");

		collision = GetNode<CollisionShape2D>("CollisionShape2D");

	}

	public override void _Process(double delta)
	{	
		playerDirection = Input.GetVector("Left", "Right", "Up", "Down");

		Velocity = playerDirection * speed;
	
		GD.Print( MoveAndCollide( Velocity * (float)delta) );

		LookAt(GetGlobalMousePosition() ); //rotate player to mouse direction
	}
}
