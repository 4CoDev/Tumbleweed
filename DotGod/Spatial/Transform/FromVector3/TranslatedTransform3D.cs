using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Transform.FromVector3;

public sealed class TranslatedTransform3D : ScalarEnvelope<Transform3D>
{
	public TranslatedTransform3D
	(
		IScalar<Transform3D> transform,
		IScalar<Vector3> translation
	) : base
	(
		new ResultOfFunction<Transform3D>(
			() => transform.Value.Translated(translation.Value))
	)
	{
	}
}