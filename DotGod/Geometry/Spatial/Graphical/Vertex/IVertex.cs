using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public interface IVertex
{
	IPoint<IReal> Translation { get; }

	IPoint<IReal> Normal { get; }
	
	IScalar<Color> Color { get; }

	Tumbleweed.Point.Planar.IPoint<IReal> UV { get; }
}