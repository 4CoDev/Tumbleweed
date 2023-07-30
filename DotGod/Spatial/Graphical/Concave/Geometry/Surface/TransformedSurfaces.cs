using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public sealed class TransformedSurfaces : Tumbleweed.Enumerable.Envelope<ISurface>
{
	public TransformedSurfaces
	(
		IEnumerable<ISurface> surfaces,
		Any<Transform3D> transform
	) : base
	(
		new Selected<ISurface>(
			surfaces,
			surface => new TransformedSurface(surface, transform))
	)
	{
	}
}