using Point = Tumbleweed.Point.Planar;
using Real = Tumbleweed.Number.Real;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Coordinate = DotGod.Vector.Planar.Coordinate;

namespace DotGod.Point.Planar.From.Vector;

public sealed class One : Point::Envelope<Real::Any>
{
	public One(Godot::Vector2 vector) : this
	(
		new Scalar::With.Value<Godot::Vector2>(vector)
	)
	{
	}

	public One(Scalar::Any<Godot::Vector2> vector) : base
	(
		new Point::With.Coordinates<Real::Any>(
			new Coordinate::X.Tumbleweed.One(vector),
			new Coordinate::Y.Tumbleweed.One(vector))
	)
	{
	}
}