using DotGod.Geometry.Stereometry.Graphical.Mesh.With.Surfaces;

namespace DotGod.Geometry.Stereometry.Graphical.Mesh;

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