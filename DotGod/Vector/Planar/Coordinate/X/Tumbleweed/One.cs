using Real = Tumbleweed.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Coordinate = DotGod.Vector.Planar.Coordinate;

namespace DotGod.Vector.Planar.Coordinate.X.Tumbleweed;

public sealed class One : Real::Envelope
{
	public One(Godot::Vector2 vector) : this
	(
		new Scalar::With.Value<Godot::Vector2>(vector)
	)
	{
	}
	
	public One(Scalar::Any<Godot::Vector2> vector) : base
	(
		new Real::Binary.Precision.Single.From.System.One(
			new Coordinate::X.System.One(vector))
	)
	{
	}
}