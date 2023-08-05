using Real = Tumbleweed.Number.Real;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Coordinate = DotGod.Vector.Spatial.Coordinate;

namespace DotGod.Vector.Spatial.Coordinate.Z.Tumbleweed;

public sealed class One : Real::Envelope
{
	public One(Godot::Vector3 vector) : this
	(
		new Scalar::With.Value<Godot::Vector3>(vector)
	)
	{
	}
	
	public One(Scalar::Any<Godot::Vector3> vector) : base
	(
		new Real::Binary.Precision.Single.From.System.One(
			new Coordinate::Z.System.One(vector))
	)
	{
	}
}