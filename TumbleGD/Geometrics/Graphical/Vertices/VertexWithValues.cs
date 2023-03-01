using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class VertexWithValues : IVertex
{
	public VertexWithValues
	(
		ISpatial<IFractional> translation,
		ISpatial<IFractional> normal,
		IScalar<Color> color,
		IPlanar<IFractional> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public ISpatial<IFractional> Translation { get; }
	
	public ISpatial<IFractional> Normal { get; }
	
	public IScalar<Color> Color { get; }
	
	public IPlanar<IFractional> UV { get; }
}