using DotGod.Geometry.Spatial.Graphical.Mesh;
using Tumbleweed.Enumerable;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Mesh;

public sealed class Enumerable : Geometry.Spatial.Graphical.Mesh.Envelope
{
	public Enumerable
	(
		IEnumerable<Any> entities
	) : base
	(
		new Merged(
			new Selected<Any, Geometry.Spatial.Graphical.Mesh.Any>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}