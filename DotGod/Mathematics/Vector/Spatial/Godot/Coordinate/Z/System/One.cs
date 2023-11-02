using Property = Tumbleweed.Property.Output;
using System = System;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Spatial.Godot.Coordinate.Z.System;

public sealed class One : Property::Envelope<System::Single>
{
	public One(Godot::Vector3 vector) : this
	(
		new Property::With.Value.One<Godot::Vector3>(vector)
	)
	{
	}
	
	public One(Property::Any<Godot::Vector3> vector) : base
	(
		new Property::Function.Result.Actual<System::Single>(
			() => vector.Value.Z)
	)
	{
	}
}