using DotGod.Point.Spatial.From.Vector;
using DotGod.Transform.Spatial.FromSpatial;
using DotGod.Transform.Spatial.Number.Binary.Spatial.OfGodot;
using Godot;
using Tumbleweed.Number.Real;

namespace DotGod.Point.Spatial.Transformed;

public sealed class One : Tumbleweed.Point.Spatial.Envelope<Any>
{
	public One
	(Tumbleweed.Point.Spatial.Any<Any> point, Tumbleweed.Scalar.Immutable.Any<Transform3D> transform
	) : base
	(
		new From.Vector.One(
			new OriginOfTransform(
				new TranslatedTransform3D(transform, point)))
	)
	{
	}
}