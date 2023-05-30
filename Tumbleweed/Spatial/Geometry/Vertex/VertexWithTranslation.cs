using Tumbleweed.Spatial.Point;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace Tumbleweed.Spatial.Geometry.Vertex;

public sealed class VertexWithTranslation : IVertex
{
	public VertexWithTranslation(IPoint<IRealNumber> translation) =>
		Translation = translation;

	public IPoint<IRealNumber> Translation { get; }
}