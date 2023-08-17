using Mesh = DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using Surface = DotGod.Geometry.Spatial.Concave.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh;

public sealed class Empty : Mesh::Envelope
{
	public Empty() : base
	(
		new Mesh::With.Surfaces.One(
			new List<Surface::Any>())
	)
	{
	}
}