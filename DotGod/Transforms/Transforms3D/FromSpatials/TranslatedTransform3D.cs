using DotGod.Vectors.Spatial.Godot;
using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Transforms.Transforms3D.FromSpatials;

public sealed class TranslatedTransform3D : ScalarEnvelope<Transform3D>
{
	public TranslatedTransform3D
	(
		IScalar<Transform3D> transform,
		IPoint<IReal> translation
	) : base
	(
		new FromVectors3.TranslatedTransform3D(
			transform,
			new Vector3FromPoint(translation))
	)
	{
	}
}