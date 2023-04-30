using Godot;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Vertices;

public sealed class VertexWithValues : IVertex
{
	public VertexWithValues
	(
		ISpatial<IReal> translation,
		ISpatial<IReal> normal,
		IScalar<Color> color,
		IPlanar<IReal> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public ISpatial<IReal> Translation { get; }
	
	public ISpatial<IReal> Normal { get; }
	
	public IScalar<Color> Color { get; }
	
	public IPlanar<IReal> UV { get; }
}