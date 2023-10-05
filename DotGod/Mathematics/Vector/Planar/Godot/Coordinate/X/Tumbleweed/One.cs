using Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Planar.Godot.Coordinate.X.Tumbleweed;

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
			new System.One(vector))
	)
	{
	}
}