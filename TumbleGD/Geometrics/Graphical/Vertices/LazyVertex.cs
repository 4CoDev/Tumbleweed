using TumbleGD.Geometrics.Graphical.Colors;
using TumbleGD.Geometrics.Graphical.Normals;
using TumbleGD.Geometrics.Graphical.Translations;
using TumbleGD.Geometrics.Graphical.UVs;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class LazyVertex : VertexEnvelope
{
	public LazyVertex(IVertex vertex) : base
	(
		new VertexWithValues(
			new LazyTranslationOfVertex(vertex),
			new LazyNormalOfVertex(vertex),
			new LazyColorOfVertex(vertex),
			new LazyUVOfVertex(vertex))
	)
	{
	}
}