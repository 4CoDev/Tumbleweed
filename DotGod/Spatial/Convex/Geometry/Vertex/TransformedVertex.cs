using DotGod.Spatial.Point;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Geometry.Vertex;

namespace DotGod.Spatial.Convex.Geometry.Vertex;

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