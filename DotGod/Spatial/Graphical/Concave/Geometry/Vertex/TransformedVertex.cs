using DotGod.Spatial.Point;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class TransformedVertex : VertexEnvelope
{
	public TransformedVertex
	(
		IVertex vertex,
		IScalar<Transform3D> transform
	) : base
	(
		new VertexWithValues(
			new TransformedPoint(vertex.Translation, transform),
			vertex.Normal,
			vertex.Color,
			vertex.UV)
	)
	{
	}
}
