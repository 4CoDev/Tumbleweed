using Godot;
using TumbleGD.Numerics.Decimals.Spatials.FromGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

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
