using Tumbleweed.Point.Spatial;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertex;

public interface IVertex
{
	IPoint<IRealNumber> Translation { get; }
}