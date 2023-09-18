using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace DotGod.Geometry.Spatial.Graphical.Vertex.Color;

public sealed class Actual : Envelope<Godot.Color>
{
	public Actual(Any vertex) : base
	(
		new Actual<Godot.Color>(
			() => vertex.Color.Value)
	)
	{
	}
}