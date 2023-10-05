using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;
using Real = Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Coordinate = DotGod.Vector.Spatial.Coordinate;

namespace DotGod.Point.Spatial.From.Vector;

public sealed class One : Envelope<Any>
{
	public One(Godot::Vector3 vector) : this
	(
		new Scalar::With.Value<Godot::Vector3>(vector)
	)
	{
	}

	public One(Scalar::Any<Godot::Vector3> vector) : base
	(
		new Unique(
			new Coordinate::X.Tumbleweed.One(vector),
			new Coordinate::X.Tumbleweed.One(vector),
			new Coordinate::X.Tumbleweed.One(vector))
	)
	{
	}
}