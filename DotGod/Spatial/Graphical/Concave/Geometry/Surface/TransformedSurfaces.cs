using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public sealed class TransformedSurfaces : EnumerableEnvelope<ISurface>
{
	public TransformedSurfaces
	(
		IEnumerable<ISurface> surfaces,
		IScalar<Transform3D> transform
	) : base
	(
		new SelectedByExpression<ISurface>(
			surfaces,
			surface => new TransformedSurface(surface, transform))
	)
	{
	}
}