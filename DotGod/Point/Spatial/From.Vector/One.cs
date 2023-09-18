using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;
using Coordinate = DotGod.Vector.Spatial.Coordinate;

namespace DotGod.Point.Spatial.From.Vector;

public sealed class One : Point::Generic.Envelope<Real::Any>
{
	public One(Godot::Vector3 vector) : this
	(
		new Scalar::With.Value<Godot::Vector3>(vector)
	)
	{
	}

	public One(Scalar::Any<Godot::Vector3> vector) : base
	(
		new Point::Real.With.Coordinate.Definition.Unique(
			new Coordinate::X.Tumbleweed.One(vector),
			new Coordinate::X.Tumbleweed.One(vector),
			new Coordinate::X.Tumbleweed.One(vector))
	)
	{
	}
}