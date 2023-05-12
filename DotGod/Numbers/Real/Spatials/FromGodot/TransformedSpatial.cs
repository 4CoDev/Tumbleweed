using DotGod.Transforms.Transforms3D.FromSpatials;
using DotGod.Transforms.Transforms3D.Numerics.Binaries.Spatials.OfGodot;
using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Numbers.Real.Spatials.FromGodot;

public sealed class TransformedSpatial : SpatialEnvelope<IReal>
{
	public TransformedSpatial
	(
		ISpatial<IReal> spatial,
		IScalar<Transform3D> transform
	) : base
	(
		new SpatialFromVector3(
			new OriginOfTransform(
				new TranslatedTransform3D(transform, spatial)))
	)
	{
	}
}