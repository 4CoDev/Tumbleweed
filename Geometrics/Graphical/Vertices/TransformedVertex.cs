using Godot;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Vertices;

public sealed class TransformedVertex : VertexEnvelope
{
	public TransformedVertex
	(
		IVertex vertex,
		IScalar<Transform3D> transform
	) : base
	(
		new VertexFromValues(
			new Transformed(vertex.Translation, transform),
			vertex.Normal,
			vertex.Color,
			vertex.UV)
	)
	{
	}
}
