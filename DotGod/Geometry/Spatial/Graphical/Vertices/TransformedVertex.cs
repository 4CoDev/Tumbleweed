using DotGod.Points.Spatial;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

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
