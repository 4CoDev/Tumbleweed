using Tumbleweed.Spatial.Point;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace Tumbleweed.Spatial.Geometry.Vertex;

public interface IVertex
{
	IPoint<IRealNumber> Translation { get; }
}