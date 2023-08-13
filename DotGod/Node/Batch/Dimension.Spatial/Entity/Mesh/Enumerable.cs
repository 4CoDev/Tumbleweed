using DotGod.Geometry.Spatial.Concave.Graphical.Mesh;
using Tumbleweed.Enumerable;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Mesh;

public sealed class Enumerable : Geometry.Spatial.Concave.Graphical.Mesh.Envelope
{
	public Enumerable
	(
		IEnumerable<Any> entities
	) : base
	(
		new Merged(
			new Selected<Any, Geometry.Spatial.Concave.Graphical.Mesh.Any>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}