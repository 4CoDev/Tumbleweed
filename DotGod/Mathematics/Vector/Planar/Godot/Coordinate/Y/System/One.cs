using Scalar = Tumbleweed.Scalar.Immutable;
using System = System;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Planar.Godot.Coordinate.Y.System;

public sealed class One : Scalar::Envelope<System::Single>
{
	public One(Godot::Vector2 vector) : this
	(
		new Scalar::With.Value<Godot::Vector2>(vector)
	)
	{
	}
	
	public One(Scalar::Any<Godot::Vector2> vector) : base
	(
		new Scalar::Function.Result.Actual<System::Single>(
			() => vector.Value.Y)
	)
	{
	}
}