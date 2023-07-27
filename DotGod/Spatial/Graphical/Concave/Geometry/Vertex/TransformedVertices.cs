using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class TransformedVertices : Tumbleweed.Enumerable.Envelope<IVertex>
{
	public TransformedVertices
	(
		IEnumerable<IVertex> vertices,
		Any<Transform3D> transform
	) : base
	(
		new Selected<IVertex>(
			vertices,
			vertex => new TransformedVertex(vertex, transform))
	)
	{
	}
}
