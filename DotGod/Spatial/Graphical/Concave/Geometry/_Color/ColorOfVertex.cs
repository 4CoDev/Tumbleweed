using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Color;

public sealed class ColorOfVertex : Envelope<Color>
{
	public ColorOfVertex(IVertex vertex) : base
	(
		new Actual<Color>(
			() => vertex.Color.Value)
	)
	{
	}
}