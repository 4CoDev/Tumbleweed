using DotGod.Geometry.Spatial.Graphical.Mesh.With.Surfaces;

namespace DotGod.Geometry.Spatial.Graphical.Mesh;

public sealed class Empty : Envelope
{
	public Empty() : base
	(
		new One(
			new List<Graphical.Surface.Any>())
	)
	{
	}
}