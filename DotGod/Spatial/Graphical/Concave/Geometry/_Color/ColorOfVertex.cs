using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Color;

public sealed class ColorOfVertex : Envelope<Color>
{
	public ColorOfVertex(IVertex vertex) : base
	(
		new Tumbleweed.Scalar.Function.Result<Color>(
			() => vertex.Color.Value)
	)
	{
	}
}