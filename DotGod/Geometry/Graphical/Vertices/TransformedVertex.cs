using DotGod.Numerics.Decimals.Spatials.FromGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Vertices;

public sealed class TransformedVertex : VertexEnvelope
{
	public TransformedVertex
	(
		IVertex vertex,
		IScalar<Transform3D> transform
	) : base
	(
		new VertexWithValues(
			new TransformedSpatial(vertex.Translation, transform),
			vertex.Normal,
			vertex.Color,
			vertex.UV)
	)
	{
	}
}
