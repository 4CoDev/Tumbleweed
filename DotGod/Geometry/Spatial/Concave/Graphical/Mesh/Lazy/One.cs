using DotGod.Geometry.Spatial.Concave.Graphical.Mesh.Surface.Enumerable;
using DotGod.Geometry.Spatial.Concave.Graphical.Mesh.With.Surfaces;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh.Lazy;

public sealed class One : Envelope
{
	public One(Any mesh) : base
	(
		new With.Surfaces.One(
			new Surface.Enumerable.Lazy(mesh))
	)
	{
	}
}