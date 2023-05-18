using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public sealed class VertexWithTranslation : IVertex
{
	public VertexWithTranslation(IPoint<IRealNumber> translation) =>
		Translation = translation;

	public IPoint<IRealNumber> Translation { get; }
}