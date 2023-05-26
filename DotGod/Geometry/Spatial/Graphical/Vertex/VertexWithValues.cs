using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public sealed class VertexWithValues : IVertex
{
	public VertexWithValues
	(IPoint<IReal> translation, IPoint<IReal> normal,
		IScalar<Color> color, Tumbleweed.Point.Planar.IPoint<IReal> uv
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
	
	public Tumbleweed.Point.Planar.IPoint<IReal> UV { get; }
}