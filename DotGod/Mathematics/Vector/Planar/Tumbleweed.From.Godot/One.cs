using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Planar.Generic.With.Coordinate.Definition;
using Godot = Godot;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Vector.Planar.Tumbleweed.From.Godot;

public sealed class One : global::Tumbleweed.Mathematics.Vector.Planar.Generic.Envelope<Any>
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
			new Planar.Godot.Coordinate.X.Tumbleweed.One(vector),
			new Planar.Godot.Coordinate.Y.Tumbleweed.One(vector))
	)
	{
	}
}