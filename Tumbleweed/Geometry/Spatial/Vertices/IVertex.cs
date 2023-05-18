using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public interface IVertex
{
	IPoint<IRealNumber> Translation { get; }
}