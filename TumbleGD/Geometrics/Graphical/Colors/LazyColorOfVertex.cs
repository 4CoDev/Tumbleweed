using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Colors;

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