using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;
using Tumbleweed.Enumerable;

namespace DotGod.Node.Batch.Dimension.Spatial.Entity.Mesh;

public sealed class Enumerable : Mathematics.Geometry.Stereometry.Graphical.Mesh.Envelope
{
	public Enumerable
	(
		IEnumerable<Any> entities
	) : base
	(
		new Merged(
			new Selected<Any, Mathematics.Geometry.Stereometry.Graphical.Mesh.Any>(
				entities,
				entity => entity.Mesh))
	)
	{
	}
}