using DotGod.Node.Batch.Dimension.Spatial.Space.Covering.Vertex;
using Enumerable = Tumbleweed.Geometry.Spatial.Convex.Mesh.Vertex.Enumerable;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.Covering.Mesh;

public sealed class One : Envelope
{
	public One(Tumbleweed.Geometry.Spatial.Convex.Mesh.Any mesh) : base
	(
		new Multiple(
			new Enumerable(mesh))
	)
	{
	}
}