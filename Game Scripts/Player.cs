using Godot;
using System;

public partial class Player : CharacterBody2D
{
	Marker2D pivotPoint;

	KinematicCollision2D collision;

	Vector2 playerDirection; //walking direction

	float angle = Mathf.Pi / 2;

	float speed = 400;

	public override void _Ready()
	{	
		pivotPoint = GetNode<Marker2D>("Pivot Point");

	}

	public override void _Process(double delta)
	{	
		playerDirection = Input.GetVector("Left", "Right", "Up", "Down");

		Velocity = playerDirection * speed;

		collision = MoveAndCollide(Velocity * (float)delta);
		
		if ( collision != null)
		{	
			if ( (Node)collision.GetCollider() is StaticBody2D )
			{
				GD.Print( "colliding with static body2d" ) ;
			}
		}	
		else
		{
			GD.Print("Colliding nothing");
		}	

		LookAt( GetGlobalMousePosition() ); //rotate player to mouse direction
	}
}
