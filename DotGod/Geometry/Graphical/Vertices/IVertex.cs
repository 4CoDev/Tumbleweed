using Godot;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Vertices;

public interface IVertex
{
	ISpatial<IReal> Translation { get; }

	ISpatial<IReal> Normal { get; }
	
	IScalar<Color> Color { get; }
	
	IPlanar<IReal> UV { get; }
}