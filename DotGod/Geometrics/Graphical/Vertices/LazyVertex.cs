using DotGod.Geometrics.Graphical.Colors;
using DotGod.Geometrics.Graphical.Normals;
using DotGod.Geometrics.Graphical.Translations;
using DotGod.Geometrics.Graphical.UVs;

namespace DotGod.Geometrics.Graphical.Vertices;

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