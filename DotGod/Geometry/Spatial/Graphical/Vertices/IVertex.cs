using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

public interface IVertex
{
	Tumbleweed.Points.Spatial.IPoint<IReal> Translation { get; }

	Tumbleweed.Points.Spatial.IPoint<IReal> Normal { get; }
	
	IScalar<Color> Color { get; }

	Tumbleweed.Points.Planar.IPoint<IReal> UV { get; }
}