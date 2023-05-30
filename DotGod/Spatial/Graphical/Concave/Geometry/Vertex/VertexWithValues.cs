using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class VertexWithValues : IVertex
{
	public VertexWithValues
	(IPoint<IReal> translation, IPoint<IReal> normal,
		IScalar<Color> color, Tumbleweed.Planar.Point.IPoint<IReal> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public IPoint<IReal> Translation { get; }
	
	public IPoint<IReal> Normal { get; }
	
	public IScalar<Color> Color { get; }
	
	public Tumbleweed.Planar.Point.IPoint<IReal> UV { get; }
}