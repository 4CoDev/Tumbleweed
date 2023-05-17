using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

public interface IVertex
{
	ISpatial<IReal> Translation { get; }

	ISpatial<IReal> Normal { get; }
	
	IScalar<Color> Color { get; }
	
	IPlanar<IReal> UV { get; }
}