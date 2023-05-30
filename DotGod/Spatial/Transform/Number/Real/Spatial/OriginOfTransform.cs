using DotGod.Spatial.Vector.Point;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Transform.Number.Real.Spatial;

public sealed class OriginOfTransform : PointEnvelope<IReal>
{
	public OriginOfTransform(IScalar<Godot.Transform3D> transform) : base
	(
		new PointFromVector3(
			new Binary.Spatial.OfGodot.OriginOfTransform(transform))
	)
	{
	}
}