using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public interface IVertex
{
	IPoint<IReal> Translation { get; }

	IPoint<IReal> Normal { get; }
	
	IScalar<Color> Color { get; }

	Tumbleweed.Planar.Point.IPoint<IReal> UV { get; }
}