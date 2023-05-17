using DotGod.Geometry.Spatial.Graphical.Vertices;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Colors;

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