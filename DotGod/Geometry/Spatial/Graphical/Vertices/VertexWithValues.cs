using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

public sealed class VertexWithValues : IVertex
{
	public VertexWithValues
	(Tumbleweed.Points.Spatial.IPoint<IReal> translation, Tumbleweed.Points.Spatial.IPoint<IReal> normal,
		IScalar<Color> color, Tumbleweed.Points.Planar.IPoint<IReal> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public Tumbleweed.Points.Spatial.IPoint<IReal> Translation { get; }
	
	public Tumbleweed.Points.Spatial.IPoint<IReal> Normal { get; }
	
	public IScalar<Color> Color { get; }
	
	public Tumbleweed.Points.Planar.IPoint<IReal> UV { get; }
}