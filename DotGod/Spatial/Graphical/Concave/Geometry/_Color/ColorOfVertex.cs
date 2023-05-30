using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Color;

public sealed class ColorOfVertex : ScalarEnvelope<Color>
{
	public ColorOfVertex(IVertex vertex) : base
	(
		new ResultOfFunction<Color>(
			() => vertex.Color.Value)
	)
	{
	}
}