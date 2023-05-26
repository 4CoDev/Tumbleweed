using DotGod.Geometry.Spatial.Graphical.Vertex;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Color;

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