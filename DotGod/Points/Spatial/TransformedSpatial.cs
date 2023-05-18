using DotGod.Transforms.Transforms3D.FromSpatials;
using DotGod.Transforms.Transforms3D.Numerics.Binaries.Spatials.OfGodot;
using DotGod.Vectors.Spatial.Points;
using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Points.Spatial;

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