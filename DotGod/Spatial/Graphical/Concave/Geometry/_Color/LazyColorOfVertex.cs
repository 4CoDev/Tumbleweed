using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Lazy;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Color;

public sealed class LazyColorOfVertex : Envelope<Color>
{
	public LazyColorOfVertex(IVertex vertex) : base
	(
		new OfValue<Color>(
			new ColorOfVertex(vertex))
	)
	{
	}
}