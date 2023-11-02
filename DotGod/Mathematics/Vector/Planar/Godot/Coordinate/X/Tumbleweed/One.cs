using Tumbleweed.Mathematics.Number.Real;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Planar.Godot.Coordinate.X.Tumbleweed;

public sealed class One : Envelope
{
	public One(Godot::Vector2 vector) : this
	(
		new Property::With.Value.One<Godot::Vector2>(vector)
	)
	{
	}
	
	public One(Property::Any<Godot::Vector2> vector) : base
	(
		new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System.One(
			new System.One(vector))
	)
	{
	}
}