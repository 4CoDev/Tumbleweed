using DotGod.Spatial.Vector.Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Transform.FromSpatial;

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