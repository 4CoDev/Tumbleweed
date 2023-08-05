using Scalar = Tumbleweed.Scalar.Immutable;
using System = System;
using Godot = Godot;

namespace DotGod.Vector.Spatial.Coordinate.Z.System;

public sealed class One : Scalar::Envelope<System::Single>
{
	public One(Godot::Vector3 vector) : this
	(
		new Scalar::With.Value<Godot::Vector3>(vector)
	)
	{
	}
	
	public One(Scalar::Any<Godot::Vector3> vector) : base
	(
		new Scalar::Function.Result.Actual<System::Single>(
			() => vector.Value.Z)
	)
	{
	}
}