using DotGod.Geometrics.Graphical.Vertices;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Colors;

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