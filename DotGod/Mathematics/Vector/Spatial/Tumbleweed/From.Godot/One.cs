using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Real.With.Coordinate.Definition;
using Godot = Godot;
using Property = Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Vector.Spatial.Tumbleweed.From.Godot;

public sealed class One : global::Tumbleweed.Mathematics.Vector.Spatial.Generic.Envelope<Any>
{
	public One(Godot::Vector3 vector) : this
	(
		new Property::With.Value.One<Godot::Vector3>(vector)
	)
	{
	}

	public One(Property::Any<Godot::Vector3> vector) : base
	(
		new Unique(
			new Spatial.Godot.Coordinate.X.Tumbleweed.One(vector),
			new Spatial.Godot.Coordinate.Y.Tumbleweed.One(vector),
			new Spatial.Godot.Coordinate.Z.Tumbleweed.One(vector))
	)
	{
	}
}