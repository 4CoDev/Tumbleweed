using Tumbleweed.Mathematics.Number.Real;
using Real = Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Coordinate = DotGod.Vector.Spatial.Coordinate;

namespace DotGod.Vector.Spatial.Coordinate.Y.Tumbleweed;

public sealed class One : Envelope
{
	public One(Godot::Vector3 vector) : this
	(
		new Scalar::With.Value<Godot::Vector3>(vector)
	)
	{
	}
	
	public One(Scalar::Any<Godot::Vector3> vector) : base
	(
		new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.From.System.One(
			new Coordinate::Y.System.One(vector))
	)
	{
	}
}