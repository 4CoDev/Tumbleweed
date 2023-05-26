using DotGod.Vector.Spatial.Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Transform.Transform3D.FromSpatial;

public sealed class TranslatedTransform3D : ScalarEnvelope<Godot.Transform3D>
{
	public TranslatedTransform3D
	(
		IScalar<Godot.Transform3D> transform,
		IPoint<IReal> translation
	) : base
	(
		new FromVector3.TranslatedTransform3D(
			transform,
			new Vector3FromPoint(translation))
	)
	{
	}
}