using Godot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class VertexFromScalar : IVertex
{
	public VertexFromScalar(IScalar<IVertex> scalar)
	{
		this.scalar = scalar;
	}
	
	public ISpatial<IDecimal> Translation => scalar.Value.Translation;

	public ISpatial<IDecimal> Normal => scalar.Value.Normal;

	public IScalar<Color> Color => scalar.Value.Color;

	public IPlanar<IDecimal> UV => scalar.Value.UV;

	private readonly IScalar<IVertex> scalar;
}