using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Color;

public sealed class LazyColorOfVertex : ScalarEnvelope<Godot.Color>
{
	public LazyColorOfVertex(IVertex vertex) : base
	(
		new LazyValue<Godot.Color>(
			new ColorOfVertex(vertex))
	)
	{
	}
}