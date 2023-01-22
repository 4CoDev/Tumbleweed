using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Surfaces;

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