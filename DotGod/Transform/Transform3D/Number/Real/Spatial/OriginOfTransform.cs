using DotGod.Vector.Spatial.Point;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Transform.Transform3D.Number.Real.Spatial;

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