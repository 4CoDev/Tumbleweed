using DotGod.Vector.Spatial.From.Point;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Transform.FromSpatial;

public sealed class TranslatedTransform3D : Tumbleweed.Scalar.Immutable.Envelope<Transform3D>
{
	public TranslatedTransform3D
	(Tumbleweed.Scalar.Immutable.Any<Transform3D> transform, Tumbleweed.Point.Spatial.Any<Any> translation
	) : base
	(
		new FromVector3.TranslatedTransform3D(
			transform,
			new One(translation))
	)
	{
	}
}