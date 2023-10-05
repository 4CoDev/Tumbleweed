using Tumbleweed.Mathematics.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Spatial.Godot.Coordinate.Z.Tumbleweed;

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
			new System.One(vector))
	)
	{
	}
}