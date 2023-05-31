using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Color;

public sealed class LazyColorOfVertex : ScalarEnvelope<Color>
{
	public LazyColorOfVertex(IVertex vertex) : base
	(
		new LazyValue<Color>(
			new ColorOfVertex(vertex))
	)
	{
	}
}