using Godot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class VertexWithValues : IVertex
{
	public VertexWithValues
	(
		ISpatial<IDecimal> translation,
		ISpatial<IDecimal> normal,
		IScalar<Color> color,
		IPlanar<IDecimal> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public ISpatial<IDecimal> Translation { get; }
	
	public ISpatial<IDecimal> Normal { get; }
	
	public IScalar<Color> Color { get; }
	
	public IPlanar<IDecimal> UV { get; }
}