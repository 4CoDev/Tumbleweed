using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
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