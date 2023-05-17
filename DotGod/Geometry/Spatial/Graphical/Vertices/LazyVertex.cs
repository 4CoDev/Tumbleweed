using DotGod.Geometry.Spatial.Graphical.Colors;
using DotGod.Geometry.Spatial.Graphical.Normals;
using DotGod.Geometry.Spatial.Graphical.Translations;
using DotGod.Geometry.Spatial.Graphical.UVs;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

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