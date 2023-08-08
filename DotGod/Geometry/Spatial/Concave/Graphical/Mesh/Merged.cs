using DotGod.Geometry.Spatial.Concave.Graphical.Mesh.With.Surfaces;
using Surface = DotGod.Geometry.Spatial.Concave.Graphical.Surface;
using Tumbleweed.Enumerable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh;

public sealed class Merged : Envelope
{
	public Merged(IEnumerable<Any> meshes) : base
	(
		new One(
			new Concatenated<Surface::Any>(
				new Selected<Any, IEnumerable<Surface::Any>>(
					meshes,
					mesh => mesh.Surfaces)))
	)
	{
	}
}