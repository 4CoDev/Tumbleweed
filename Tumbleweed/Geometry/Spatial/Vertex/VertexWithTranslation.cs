using Tumbleweed.Point.Spatial;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertex;

public sealed class VertexWithTranslation : IVertex
{
	public VertexWithTranslation(IPoint<IRealNumber> translation) =>
		Translation = translation;

	public IPoint<IRealNumber> Translation { get; }
}