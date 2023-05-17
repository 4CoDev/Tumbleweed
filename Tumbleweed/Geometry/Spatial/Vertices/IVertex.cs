using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public interface IVertex
{
	ISpatial<IRealNumber> Translation { get; }
}