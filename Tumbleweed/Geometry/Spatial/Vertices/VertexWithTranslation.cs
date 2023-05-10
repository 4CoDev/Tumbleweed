using Tumbleweed.Numbers.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public sealed class VertexWithTranslation : IVertex
{
	public VertexWithTranslation(ISpatial<IRealNumber> translation) =>
		Translation = translation;

	public ISpatial<IRealNumber> Translation { get; }
}