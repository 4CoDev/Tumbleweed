using IRealNumber = Tumbleweed.Numbers.Real.IReal;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Geometry.Spatial.Vertices;

public interface IVertex
{
	ISpatial<IRealNumber> Translation { get; }
}