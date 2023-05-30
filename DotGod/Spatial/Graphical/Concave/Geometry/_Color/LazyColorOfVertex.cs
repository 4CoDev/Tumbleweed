using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Color;

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