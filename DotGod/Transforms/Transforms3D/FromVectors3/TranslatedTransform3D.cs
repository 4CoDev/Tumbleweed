using Godot;
using DotGod.Numerics.Decimals.Spatials.ToGodot;
using Tumbleweed.Scalars;

namespace DotGod.Transforms.Transforms3D.FromVectors3;

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