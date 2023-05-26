using DotGod.Point.Spatial;
using Godot;
using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Convex.Vertex;

public sealed class TransformedVertex : VertexEnvelope
{
	public TransformedVertex
	(
		IVertex vertex,
		IScalar<Transform3D> transform
	) : base
	(
		new VertexWithTranslation(
			new TransformedPoint(
				new TranslationOfVertex(vertex),
				transform))
	)
	{
	}
}