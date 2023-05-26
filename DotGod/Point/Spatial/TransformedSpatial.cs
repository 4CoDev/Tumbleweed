using DotGod.Transform.Transform3D.FromSpatial;
using DotGod.Transform.Transform3D.Number.Binary.Spatial.OfGodot;
using DotGod.Vector.Spatial.Point;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Point.Spatial;

public sealed class TransformedPoint : PointEnvelope<IReal>
{
	public TransformedPoint
	(
		IPoint<IReal> point,
		IScalar<Transform3D> transform
	) : base
	(
		new PointFromVector3(
			new OriginOfTransform(
				new TranslatedTransform3D(transform, point)))
	)
	{
	}
}