using DotGod.Spatial.Transform.FromSpatial;
using DotGod.Spatial.Transform.Number.Binary.Spatial.OfGodot;
using DotGod.Spatial.Vector.Point;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Point;

public sealed class TransformedPoint : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public TransformedPoint
	(Tumbleweed.Point.Spatial.Any<Any> point, Tumbleweed.Scalar.Immutable.Any<Transform3D> transform
	) : base
	(
		new PointFromVector3(
			new OriginOfTransform(
				new TranslatedTransform3D(transform, point)))
	)
	{
	}
}