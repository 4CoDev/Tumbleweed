using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar;
using Tumbleweed.Mathematics.Vector.Planar.Generic;
using Tumbleweed.Mathematics.Vector.Planar.Generic.With.Coordinate.Definition;
using Real = Tumbleweed.Mathematics.Number.Real;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Coordinate = DotGod.Vector.Planar.Coordinate;

namespace DotGod.Point.Planar.From.Vector;

public sealed class One : Envelope<Any>
{
	public One(Godot::Vector2 vector) : this
	(
		new Scalar::With.Value<Godot::Vector2>(vector)
	)
	{
	}

	public One(Scalar::Any<Godot::Vector2> vector) : base
	(
		new Unique<Any>(
			new Coordinate::X.Tumbleweed.One(vector),
			new Coordinate::Y.Tumbleweed.One(vector))
	)
	{
	}
}