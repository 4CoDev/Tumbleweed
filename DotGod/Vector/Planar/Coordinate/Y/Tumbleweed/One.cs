using Tumbleweed.Mathematics.Number.Real;
using Real = Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Coordinate = DotGod.Vector.Planar.Coordinate;

namespace DotGod.Vector.Planar.Coordinate.Y.Tumbleweed;

public sealed class One : Envelope
{
	public One(Godot::Vector2 vector) : this
	(
		new Scalar::With.Value<Godot::Vector2>(vector)
	)
	{
	}
	
	public One(Scalar::Any<Godot::Vector2> vector) : base
	(
		new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System.One(
			new Coordinate::Y.System.One(vector))
	)
	{
	}
}