using DotGod.Vectors.Spatial.Points;
using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Transforms.Transforms3D.Numerics.Decimals.Spatials;

public sealed class OriginOfTransform : SpatialEnvelope<IReal>
{
	public OriginOfTransform(IScalar<Transform3D> transform) : base
	(
		new SpatialFromVector3(
			new Binaries.Spatials.OfGodot.OriginOfTransform(transform))
	)
	{
	}
}