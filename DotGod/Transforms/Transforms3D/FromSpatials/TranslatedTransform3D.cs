using DotGod.Numerics.Decimals.Spatials.ToGodot;
using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Transforms.Transforms3D.FromSpatials;

public sealed class TranslatedTransform3D : ScalarEnvelope<Transform3D>
{
	public TranslatedTransform3D
	(
		IScalar<Transform3D> transform,
		ISpatial<IReal> translation
	) : base
	(
		new FromVectors3.TranslatedTransform3D(
			transform,
			new Vector3FromSpatial(translation))
	)
	{
	}
}