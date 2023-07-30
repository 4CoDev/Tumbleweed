using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Spatial.Transform.FromVector3;

public sealed class TranslatedTransform3D : Envelope<Transform3D>
{
	public TranslatedTransform3D
	(
		Any<Transform3D> transform,
		Any<Vector3> translation
	) : base
	(
		new Actual<Transform3D>(
			() => transform.Value.Translated(translation.Value))
	)
	{
	}
}