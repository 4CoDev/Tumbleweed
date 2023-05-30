using DotGod.Spatial.Transform.FromSpatial;
using DotGod.Spatial.Transform.Number.Binary.Spatial.OfGodot;
using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Point;

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