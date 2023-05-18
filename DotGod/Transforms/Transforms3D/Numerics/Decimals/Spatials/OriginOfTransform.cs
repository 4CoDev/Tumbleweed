using DotGod.Vectors.Spatial.Points;
using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Transforms.Transforms3D.Numerics.Decimals.Spatials;

public sealed class OriginOfTransform : PointEnvelope<IReal>
{
	public OriginOfTransform(IScalar<Transform3D> transform) : base
	(
		new PointFromVector3(
			new Binaries.Spatials.OfGodot.OriginOfTransform(transform))
	)
	{
	}
}