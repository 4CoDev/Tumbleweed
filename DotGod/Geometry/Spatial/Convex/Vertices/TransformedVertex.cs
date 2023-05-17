using DotGod.Points.Spatial;
using Godot;
using Tumbleweed.Geometry.Spatial.Vertices;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Convex.Vertices;

public sealed class TransformedVertex : VertexEnvelope
{
	public TransformedVertex
	(
		IVertex vertex,
		IScalar<Transform3D> transform
	) : base
	(
		new VertexWithTranslation(
			new TransformedSpatial(
				new TranslationOfVertex(vertex),
				transform))
	)
	{
	}
}