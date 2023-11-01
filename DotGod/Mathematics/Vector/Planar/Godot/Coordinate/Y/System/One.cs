using Property = Tumbleweed.Property.Output;
using System = System;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Planar.Godot.Coordinate.Y.System;

public sealed class One : Property::Envelope<System::Single>
{
	public One(Godot::Vector2 vector) : this
	(
		new Property::With.Value<Godot::Vector2>(vector)
	)
	{
	}
	
	public One(Property::Any<Godot::Vector2> vector) : base
	(
		new Property::Function.Result.Actual<System::Single>(
			() => vector.Value.Y)
	)
	{
	}
}