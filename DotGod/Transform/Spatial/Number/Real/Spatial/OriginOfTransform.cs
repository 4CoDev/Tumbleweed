using DotGod.Point.Spatial.From.Vector;
using Godot;
using Tumbleweed.Number.Real;

namespace DotGod.Transform.Spatial.Number.Real.Spatial;

public sealed class OriginOfTransform : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public OriginOfTransform(Tumbleweed.Scalar.Immutable.Any<Transform3D> transform) : base
	(
		new One(
			new Binary.Spatial.OfGodot.OriginOfTransform(transform))
	)
	{
	}
}